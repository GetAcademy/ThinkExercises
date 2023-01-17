namespace ThinkExercises
{
    internal class Exercise
    {


        public static void No2_2()
        {
            /*

            Pause til 11:00


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
            
                Budskap: 
                - analyse: se mønsteret
                - skrive kode som er logisk riktig, men gjentakelser er lov
                - når det virker, refactor bort flest mulig gjentakelser

             */
            WriteFourRows(0, 1, 6,
                1, 1, -2);
            WriteFourRows(3, 4, 0,
                -1, -1, 2);
        }

        private static void WriteFourRows(
            int spaceCount1, int hashCount, int spaceCount2,
            int changeSpaceCount1, int changeHashCount, int changeSpaceCount2
            )
        {
            for (var lineIndex = 0; lineIndex < 4; lineIndex++)
            {
                WriteRow(spaceCount1, hashCount, spaceCount2);
                spaceCount1 += changeSpaceCount1;
                hashCount += changeHashCount;
                spaceCount2 += changeSpaceCount2;
                Console.WriteLine();
            }
        }

        private static void WriteRow(int spaceCount1, int hashCount, int spaceCount2)
        {
            WriteSpacesHashesSpaces(spaceCount1, hashCount, spaceCount2);
            WriteSpacesHashesSpaces(spaceCount2, hashCount, spaceCount1);
        }

        private static void WriteSpacesHashesSpaces(int spaceCount1, int hashCount, int spaceCount2)
        {
            WriteCharacters(spaceCount1, ' ');
            WriteCharacters(hashCount, '#');
            WriteCharacters(spaceCount2, ' ');
        }

        private static void WriteCharacters(int count, char character)
        {
            for (var i = 0; i < count; i++)
            {
                Console.Write(character);
            }
        }

        //public static void No2_2_v1()
        //{
        //    /*
        //        2-3 Here’s an especially tricky one:
        //        #            #
        //         ##        ##
        //          ###    ###
        //           ########
        //           ########
        //          ###    ###
        //         ##        ##
        //        #            #             

        //        fire første linjer til midten
        //        1. Space - starter på 0 - øker med 1
        //        2. Hashtag - starter på 1 - øker med 1
        //        3. Space - starter på 6 - minker med 2        
        //     */
        //    var spaceCount1 = 0;
        //    var hashCount = 1;
        //    var spaceCount2 = 6;

        //    for (var lineIndex = 0; lineIndex < 4; lineIndex++)
        //    {
        //        for (var i = 0; i < spaceCount1; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        for (var i = 0; i < hashCount; i++)
        //        {
        //            WriteCharacters();
        //        }
        //        for (var i = 0; i < spaceCount2; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        for (var i = 0; i < spaceCount2; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        for (var i = 0; i < hashCount; i++)
        //        {
        //            WriteCharacters();
        //        }
        //        for (var i = 0; i < spaceCount1; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        spaceCount1++;
        //        hashCount++;
        //        spaceCount2 -= 2;
        //        Console.WriteLine();
        //    }

        //    for (var lineIndex = 3; lineIndex >= 0; lineIndex--)
        //    {
        //        spaceCount1--;
        //        hashCount--;
        //        spaceCount2 += 2;
        //        for (var i = 0; i < spaceCount1; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        for (var i = 0; i < hashCount; i++)
        //        {
        //            WriteCharacters();
        //        }
        //        for (var i = 0; i < spaceCount2; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        for (var i = 0; i < spaceCount2; i++)
        //        {
        //            WriteSpaces();
        //        }
        //        for (var i = 0; i < hashCount; i++)
        //        {
        //            WriteCharacters();
        //        }
        //        for (var i = 0; i < spaceCount1; i++)
        //        {
        //            WriteSpaces();
        //        }

        //        Console.WriteLine();
        //    }

        //}
    }
}
