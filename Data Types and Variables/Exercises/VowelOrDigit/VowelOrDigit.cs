using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    public class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            // Program should check if given symbol is digit, vowel or any other symbol
            var someInput = Console.ReadLine();

            try // We are catching first digits
            {
                byte value = byte.Parse(someInput);

                Console.WriteLine("digit"); // if it is a digit, print a message, if not -> go in 'catch'
            }
            catch // We are coming here when the input is not a digit
            {
                char letter = char.Parse(someInput);
                
                // We declare here the vowels
                char[] vowelsStore = new char[] { 'a', 'e', 'i', 'o', 'u', 'y'}; // begin from a - letter[0]

                // Simple check if the letter is a vowel
                bool IsVowel = letter == vowelsStore[0] // a
                            || letter == vowelsStore[1] // e
                            || letter == vowelsStore[2] // i
                            || letter == vowelsStore[3] // o
                            || letter == vowelsStore[4] // u
                            || letter == vowelsStore[5]; // y (not always y is vowel letter)

                Console.WriteLine(IsVowel ? "vowel" : "other"); // if the letter is vowel print it, else print other  
            }
        }
    }
}
