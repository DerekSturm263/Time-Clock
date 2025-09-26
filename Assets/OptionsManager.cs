using MongoDB.Bson;
using MongoDB.Driver;
using System;
using UnityEngine;
using UnityEngine.Events;

public class OptionsManager : MonoBehaviour
{
    private readonly string connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
    private MongoClient client;

    public UnityEvent<string> onFail;

    public string studentID;

    private void Awake()
    {
        client = new(connectionString);
    }

    public void ClockIn()
    {
        try
        {
            var collection = client.GetDatabase("time-clock-database").GetCollection<BsonDocument>("users");
            var filter = Builders<BsonDocument>.Filter.Eq("studentID", int.Parse(studentID));
        }
        catch (Exception e)
        {
            onFail?.Invoke(e.Message);
        }
    }

    public void ClockOut()
    {
        try
        {
            var collection = client.GetDatabase("time-clock-database").GetCollection<BsonDocument>("users");
            var filter = Builders<BsonDocument>.Filter.Eq("studentID", int.Parse(studentID));
        }
        catch (Exception e)
        {
            onFail?.Invoke(e.Message);
        }
    }

    public void ChangeLocation(string location)
    {
        try
        {
            var collection = client.GetDatabase("time-clock-database").GetCollection<BsonDocument>("users");
            var filter = Builders<BsonDocument>.Filter.Eq("studentID", int.Parse(studentID));
        }
        catch (Exception e)
        {
            onFail?.Invoke(e.Message);
        }
    }
}
