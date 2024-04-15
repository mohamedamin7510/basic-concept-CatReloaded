using System;
namespace Basic_Concepts
{
    internal class Program
    {
        /*
         there are probabilties
         -  23
         -  23 space after digits  
         -2    3
         -2 3
         -   2    3
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the two digits would you calculate it: ");
            var input=Console.ReadLine().Trim();//23
            var indexequal =input.IndexOf(' ');//2 3
            string First_Digit;
            string Second_Digit;
            int x;
            int y;
            if (indexequal != -1 )
            { 
                First_Digit = input.Substring(0,indexequal).Trim();
                Second_Digit =input.Substring(indexequal).Trim();
            }
            else 
            {
                 First_Digit = Convert.ToString(input[0]);
                 Second_Digit = Convert.ToString(input[1]);
            }

            if (int.TryParse(First_Digit,out x) && int.TryParse(Second_Digit, out y))
                Console.WriteLine($"The sum is equal: {x+y}");
            else
                Console.WriteLine("Format Exception Error");

        }
    }
}
