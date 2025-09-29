using ESCPOS;
using System.Text;
using static ESCPOS.Commands;

public static class ESCPOSManager
{
    public static void PrintBreak(UserData user, LocationInfo locationInfo)
    {
        Printer printer = new() { Encoding = Encoding.UTF8, Columns = 32, Address = "" };

        printer.AddToCache(
            printer.SameLineLeftAndRightAlignedText("Video Game Design", "Room 138"),
            LF,
            printer.HorizontalDoubleLine,
            LF,
            printer.SameLineLeftAndRightAlignedText($"{user.lastName}, {user.firstName}", ""),
            LF,
            printer.SameLineLeftAndRightAlignedText(user.studentID, ""),
            LF,
            printer.HorizontalDoubleLine,
            LF,
            printer.SameLineLeftAndRightAlignedText($"Location: {locationInfo.location}", ""),
            LF,
            LF,
            printer.SameLineLeftAndRightAlignedText($"Time Out: {locationInfo.timeOut}", ""),
            LF,
            printer.SameLineLeftAndRightAlignedText($"Time In: {locationInfo.TimeIn}", "")
        );

        printer.Print();
    }
}
