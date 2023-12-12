namespace HackerRank
{
    internal class PickingNumbers
    {
        public static int pickingNumbers(List<int> a)
        {
            var sortedList = a.Order().ToList();
            var c = a.OrderBy(x => x).ToList();
            var maxLenght = 0;
            for (int i = 0; i < sortedList.Count; i++)
            {
                var count = 1;
                var temp = sortedList[i];
                for (int j = i + 1; j < sortedList.Count; j++)
                {
                    if (Math.Abs(temp - sortedList[j]) > 1)
                    {
                        break;
                    }
                    count++;
                }
                if (maxLenght < count)
                    maxLenght = count;

            }
            return maxLenght;
        }
    }
}
