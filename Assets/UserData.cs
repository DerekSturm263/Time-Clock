using System;
using System.Collections.Generic;

public struct LocationInfo
{
    public string location;
    public DateTime timeOut;

    public readonly DateTime TimeOut => location switch
    {
        "outside" => timeOut + new TimeSpan(hours: 0, minutes: 5, seconds: 0),
        "lectureHall" => TimeOut + new TimeSpan(hours: 0, minutes: 30, seconds: 0),
        "office" => timeOut + new TimeSpan(hours: 0, minutes: 10, seconds: 0),
        "bathroom" => timeOut + new TimeSpan(hours: 0, minutes: 5, seconds: 0),
        "vendingMachine" => timeOut + new TimeSpan(hours: 0, minutes: 4, seconds: 0),
        "waterFountain" => timeOut + new TimeSpan(hours: 0, minutes: 2, seconds: 0),
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
