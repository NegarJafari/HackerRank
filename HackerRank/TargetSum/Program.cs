using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var nums = new int[5] { 1, 2, 4, 6, 7 };
        var result = TwoSum(nums, 8);
        foreach (var item in result)
        {
            Console.WriteLine($"FirstIndex : {item[0]} - SecondIndex :{item[1]} /");
        }       
        
    }

    public static List<int[]> TwoSum(int[] nums, int target)
    {

        /*Find Target value in nums*/

        var result = new List<int[]>();
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (i!=j && nums[i] + nums[j] == target)
                {
                    var CorrectIndexes = new int[2];
                    CorrectIndexes[0] = i < j ? i : j;
                    CorrectIndexes[1] = j > i ? j : i;

                    result.Add(CorrectIndexes);
                }
            }
        }
        return result;
    }
}

