using System;
using System.Collections.Generic;

public struct BreakInfo
{
    public string breakType;
    public DateTime timeTaken;
}

public struct UserData
{
    public string studentID;
    public string firstName;
    public string lastName;
    public DateTime timeIn;
    public List<BreakInfo> breaks;
}
