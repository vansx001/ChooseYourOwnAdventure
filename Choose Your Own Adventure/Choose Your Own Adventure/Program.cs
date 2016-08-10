using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! It’s Halloween and your friends ask if you want to join them to visit a REAL haunted house.\n 1. Do you go with them?\n 2. Do you stay home?\n");
            Console.WriteLine("Please enter your selection: \n");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.WriteLine("You're home safe! You have some ice cream, listen to some Backstreet Boys and go to bed.\nThe end!");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("As you enter the house, you hear creaking from upstairs. \n 1. Do you and your friends investigate upstairs? \n 2. Do you all run out and go home? \n");
                Console.WriteLine("Please enter your selection: \n");
                choice = Console.ReadLine();
            }
            if (choice == "2")
            {

                Console.WriteLine("You're home safe! You have some ice cream, listen to some Backstreet Boys and go to bed.\nThe end!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You all slowly make your way upstairs and follow the noise to the last bedroom on the left. You all fall through \na trapdoor and behold – there’s a puppy for everyone!\n");
            }

            Console.WriteLine("The end!");
            Console.ReadLine();
        }
    }
}
