using ESCPOS;
using System.Text;
using static ESCPOS.Commands;

public static class ESCPOSManager
{
    public static void Print(UserData user, LocationInfo locationInfo)
    {
        Printer printer = new() { Encoding = Encoding.UTF8, Columns = 32, Address = "" };

        printer.AddToCache(
            printer.SameLineLeftAndRightAlignedText($"{user.lastName}, {user.firstName}", ""),
            LF,
            printer.SameLineLeftAndRightAlignedText(user.studentID, ""),
            LF,
            printer.HorizontalDoubleLine,
            LF
        );
    }
}
