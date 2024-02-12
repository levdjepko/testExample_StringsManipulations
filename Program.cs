using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace stringsChangerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "bababvavav";
            string templateString = "01010";

            // Convert input string to 1 and 0, vowels become 1, rest 0s
            string newString;

            // replace all vowels with 1's
            newString = Regex.Replace(inputString, "[eioyau]", "1", RegexOptions.IgnoreCase);
             
            // replace all the rest chars with 0s
            newString = Regex.Replace(newString, "[qwrtplkhjgfdszxcvbnm]", "0", RegexOptions.IgnoreCase);

            Console.WriteLine(inputString);
            Console.WriteLine(newString);

            //Compare input string and template and add a counter if they match
            int counterOfMatches = 0;
            /*if (templateString.ElementAt(0) == newString.ElementAt(0) && templateString.ElementAt(1) == newString.ElementAt(1)&& templateString.ElementAt(2) == newString.ElementAt(2))
            {
                counterOfMatches++;
            }*/
            int temporaryHolder = 0;
            
            //iterate through all the elements of initial string (formatted to 1s and 0s)
            for (int i = 0; i <= newString.Length - templateString.Length; i++)//difference is to make sure we are not moving outside of provided string
            {
                temporaryHolder = 0;

                for (int j = 0; j < templateString.Length; j++) {

                    if (templateString.ElementAt(j) == newString.ElementAt(i + j))// I + J to make sure we are moving forward with every iteration
                    {
                        temporaryHolder++;
                    }

                    if (temporaryHolder == templateString.Length)
                    {
                        counterOfMatches++;
                    }
                }
            }

            Console.WriteLine(counterOfMatches);

        }
    }
}
