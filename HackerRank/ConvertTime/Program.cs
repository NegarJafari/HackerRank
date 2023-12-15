using HackerRank;

internal class Program
{
    static void Main(string[] args)
    {
        var convertor = new ConvertTime();
        var s = "07:05:45PM";
        string result = convertor.timeConversion(s);
        Console.WriteLine(result);
        //retrun 19:05:45
    }
}