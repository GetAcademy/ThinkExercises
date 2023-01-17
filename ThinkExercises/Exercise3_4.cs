using System.Net.Security;

namespace ThinkExercises
{
    internal class Exercise3_4
    {
        /*
            3-4 Here’s a variation on the array of const values. Write a program for creating a
            substitution cipher problem. In a substitution cipher problem, all messages
            are made of uppercase letters and punctuation. The original message is called
            the plaintext, and you create the ciphertext by substituting each letter with
            another letter (for example, each C could become an X). For this problem,
            hard-code a const array of 26 char elements for the cipher, and have your
            program read a plaintext message and output the equivalent ciphertext.         
         */
        public static void Run()
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ !.";
            var cipher   = "CDEGHIJKLMAOPQRSTUVFWXYBZÆØÅN#¤%";
            var plainText = "TERJE ER TØFFEST";

            var cipherText = Encrypt(plainText, cipher, alphabet);
            Console.WriteLine(cipherText);

            // Oppgave 3-5

            plainText = Encrypt(cipherText, alphabet, cipher);
            Console.WriteLine(plainText);
        }

        private static string Encrypt(string plainText, string secretCode, string alphabet)
        {
            var cipherText = "";
            foreach (var character in plainText)
            {
                var indexInAlphabet = alphabet.IndexOf(character);
                cipherText += secretCode[indexInAlphabet];

            }
            return cipherText;
        }
    }
}

