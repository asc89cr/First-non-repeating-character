using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_non_repeating_character
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FirstNonRepeatingLetter("sTreSS");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            var initialString = s.ToCharArray();
            var letters = s.ToUpper().ToCharArray();
            s = s.ToUpper();

            string FirstLetterNoRepeated = string.Empty;

            for (int i = 0; i < letters.Length; i++)
            {
                var count = s.Count(c => c == letters[i]);

                if (count <= 1)
                {
                    FirstLetterNoRepeated = initialString[i].ToString();
                    break;
                }

            }


            return FirstLetterNoRepeated;
        }
    }
}
