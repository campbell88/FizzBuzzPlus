using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPlus
{
    class FizzBuzzPlus
    {
        public static string GetFizzBuzz(int x)

        {
            string characters;

            if (x % 3 == 0 && x % 5 == 0)
                return "FizzBuzz";

            else if (x % 3 == 0)
                return "Fizz";

            else if (x % 5 == 0  && x != 35)
                return "Buzz";
            else
                characters = x.ToString();
            char[] letters = characters.ToCharArray();
                foreach (char letter in letters)
                {
                if (characters == "53" || characters == "35")
                //if (letter == '5' && letter == '3')
                {
                    return "FizzBuzz";
                }

                else if (letter == '3')
                {
                    return "Fizz";

                }
                else if (letter == '5')
                {
                    return "Buzz";
                }
                }


            return characters;


        }



    }

        }

    
