namespace JumpingOnTheClouds
{
    public class Jump
    {
        public int jumpingOnClouds(List<int> clouds)
        {
            var result = 0;
            var lastIndex = clouds.Count - 1;

            var counter = 0;
            while (lastIndex > counter)
            {
                if (clouds[counter] == 0)
                {
                    if (counter + 2 <= lastIndex)
                    {
                        if (clouds[counter + 2] == 0)
                        {
                            result++;
                            counter = counter + 2;
                        }
                        else if (clouds[counter + 1] == 0)
                        {
                            result++;
                            counter = counter + 1;

                        }
                    }
                    else if (counter + 1 <= lastIndex)
                    {
                        if (clouds[counter + 1] == 0)
                        {
                            result++;
                            counter = counter + 1;

                        }
                    }
                }
                else
                {
                    counter++;
                }

            }
            return result;
        }
    }
}
