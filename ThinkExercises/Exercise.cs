namespace ThinkExercises
{
    internal class Exercise
    {


        public static void No2_2()
        {
            /*
                2-3 Here’s an especially tricky one:
                #            #
                 ##        ##
                  ###    ###
                   ########
                   ########
                  ###    ###
                 ##        ##
                #            #             

                fire første linjer til midten
                1. Space - starter på 0 - øker med 1
                2. Hashtag - starter på 1 - øker med 1
                3. Space - starter på 6 - minker med 2        
             */
            var spaceCount1 = 0;
            var hashCount = 1;
            var spaceCount2 = 6;

            for (var lineIndex = 0; lineIndex < 4; lineIndex++)
            {
                for (var i = 0; i < spaceCount1; i++)
                {
                    WriteSpace();
                }
                for (var i = 0; i < hashCount; i++)
                {
                    WriteHash();
                }
                for (var i = 0; i < spaceCount2; i++)
                {
                    WriteSpace();
                }
                for (var i = 0; i < spaceCount2; i++)
                {
                    WriteSpace();
                }
                for (var i = 0; i < hashCount; i++)
                {
                    WriteHash();
                }
                for (var i = 0; i < spaceCount1; i++)
                {
                    WriteSpace();
                }
                spaceCount1++;
                hashCount++;
                spaceCount2 -= 2;
                Console.WriteLine();
            }

            for (var lineIndex = 3; lineIndex >= 0; lineIndex--)
            {
                spaceCount1--;
                hashCount--;
                spaceCount2 += 2;
                for (var i = 0; i < spaceCount1; i++)
                {
                    WriteSpace();
                }
                for (var i = 0; i < hashCount; i++)
                {
                    WriteHash();
                }
                for (var i = 0; i < spaceCount2; i++)
                {
                    WriteSpace();
                }
                for (var i = 0; i < spaceCount2; i++)
                {
                    WriteSpace();
                }
                for (var i = 0; i < hashCount; i++)
                {
                    WriteHash();
                }
                for (var i = 0; i < spaceCount1; i++)
                {
                    WriteSpace();
                }

                Console.WriteLine();
            }

        }

        private static void WriteHash()
        {
            Console.Write("#");
        }

        private static void WriteSpace()
        {
            Console.Write(" ");
        }
    }
}
