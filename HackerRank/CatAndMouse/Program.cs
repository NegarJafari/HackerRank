internal class Program
{
    static void Main(string[] args)
    {
        var result = CatAndMouse(1, 3, 2);
        Console.WriteLine(result);
    }

    /*
     * wo cats and a mouse are at various positions on a line.
     * You will be given their starting positions. 
     * Your task is to determine which cat will reach the mouse first,
     * assuming the mouse does not move and the cats travel at equal speed. 
     * If the cats arrive at the same time, the mouse will be allowed to move and it will escape while they fight.
     * f cat  catches the mouse first, print Cat A.
     * If cat  catches the mouse first, print Cat B.
     * If both cats reach the mouse at the same time, print Mouse C as the two cats fight and mouse escapes.
     */
    public static string CatAndMouse(int CatA, int CatB, int Mouse)
    {
        var distanceA = Math.Abs(CatA - Mouse);
        var distanceB = Math.Abs(CatB - Mouse);

        string? result;
        if (distanceA == distanceB)
        {
            result = "Mouse C";
        }
        else 
        {
            result = (distanceA < distanceB) ? "Cat A" : "Cat B";
        }

        return result;
    }
}