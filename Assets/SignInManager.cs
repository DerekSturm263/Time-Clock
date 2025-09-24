using MongoDB.Bson;
using MongoDB.Driver;
using System;
using UnityEngine;
using UnityEngine.Events;

public class SignInManager : MonoBehaviour
{
    private readonly string connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
    private MongoClient client;

    public UnityEvent onStartSignIn;
    public UnityEvent<UserData> onSuccess;
    public UnityEvent<string> onFail;

    private void Awake()
    {
        client = new(connectionString);
    }

    public void AttemptSignIn(string text)
    {
        onStartSignIn?.Invoke();

        try
        {
            var collection = client.GetDatabase("time-clock-database").GetCollection<BsonDocument>("users");
            var filter = Builders<BsonDocument>.Filter.Eq("studentID", int.Parse(text));

            string document = collection.Find(filter).First().AsString;
            UserData userData = JsonUtility.FromJson<UserData>(document);

            onSuccess?.Invoke(userData);
        }
        catch (Exception e)
        {
            onFail?.Invoke(e.Message);
        }
    }
}
