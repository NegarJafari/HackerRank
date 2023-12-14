internal class Program
{
    static void Main(string[] args)
    {
        var result = Revers(100250);
        Console.WriteLine(result);
    }

    private static int Revers(int n)
    {
        var reverse = 0;
        var temp = 0;
        while (n != 0)
        {
            temp = n % 10;
            reverse = reverse * 10 + temp;
            n /= 10;
        }
        return reverse;
    }
}