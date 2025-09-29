using System;
using System.Collections.Generic;

public struct LocationInfo
{
    public string location;
    public DateTime timeOut;

    public readonly DateTime TimeIn => location switch
    {
        "Outside" => timeOut + new TimeSpan(hours: 0, minutes: 5, seconds: 0),
        "Lecture Hall" => TimeOut + new TimeSpan(hours: 0, minutes: 30, seconds: 0),
        "Office" => timeOut + new TimeSpan(hours: 0, minutes: 10, seconds: 0),
        "Bathroom" => timeOut + new TimeSpan(hours: 0, minutes: 5, seconds: 0),
        "Vending Machine" => timeOut + new TimeSpan(hours: 0, minutes: 4, seconds: 0),
        "Water Fountain" => timeOut + new TimeSpan(hours: 0, minutes: 2, seconds: 0),
        _ => timeOut + new TimeSpan(hours: 0, minutes: 5, seconds: 0),
    };
}

public struct UserData
{
    public string studentID;
    public string firstName;
    public string lastName;
    public DateTime timeIn;
    public List<LocationInfo> breaks;
}
