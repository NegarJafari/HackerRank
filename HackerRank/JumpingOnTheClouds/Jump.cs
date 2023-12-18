namespace JumpingOnTheClouds
{
    public class Jump
    {
        /*
         * There is a new mobile game that starts with consecutively numbered clouds. 
         * Some of the clouds are thunderheads and others are cumulus. 
         * The player can jump on any cumulus cloud having a number that is equal to the 
         * number of the current cloud plus  or . 
         * The player must avoid the thunderheads.
         * Determine the minimum number of jumps it will take to jump from the starting postion to the last cloud. 
         * It is always possible to win the game.
         * 
         * For each game, you will get an array of clouds numbered  if they are safe or  if they must be avoided.
         */
        public int jumpingOnClouds(List<int> clouds)
        {
            var result = 0;
            var lastIndex = clouds.Count - 1;
            var counter = 0;
            if (clouds[0] != 0 || clouds[lastIndex] != 0)
            {
                return result;
            }

            while (lastIndex > counter)
            {
                if (clouds[counter] == 0)
                {
                    if (counter + 2 <= lastIndex)
                    {
                        if (clouds[counter + 2] == 0)
                        {
                            result++;
                            counter += 2;
                        }
                        else if (clouds[counter + 1] == 0)
                        {
                            result++;
                            counter ++;

                        }
                    }
                    else if (counter + 1 <= lastIndex)
                    {
                        if (clouds[counter + 1] == 0)
                        {
                            result++;
                            counter ++;

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
