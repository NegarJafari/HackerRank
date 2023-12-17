using JumpingOnTheClouds;

internal class Program
{
    static void Main(string[] args)
    {
        var jump = new Jump();
        var input = new List<int>() { 0,0,1,0,0,0,1,0};
        var result = jump.jumpingOnClouds(input);
        Console.WriteLine(result);
        //retrun 19:05:45
    }
}