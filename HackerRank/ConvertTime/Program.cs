using HackerRank;

internal class Program
{
    static void Main(string[] args)
    {
        var s = "07:05:45PM";
        string result = ConvertTime.timeConversion(s);
        Console.WriteLine(result);
        //retrun 19:05:45
    }
}