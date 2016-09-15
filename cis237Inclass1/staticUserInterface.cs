using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    //Add static keyword to make this class static.
    static class staticUserInterface
    {
        //This method has become static because the class is
        public static int GetUserInput()
        {   //Call the printMenu method anf qualify it using the name of this class
            //instead of the keywork 'this'. IT does the same thing as 'this' but since 'this' for instance
            // and static classes can't have instances we must use the class name.
            staticUserInterface.printMenu();

            //Get the input from the console.
            string input = Console.ReadLine();

            //Contime to loop while th einput is not a valid choice.
            while (input != "1" && input != "2")
            {
                //Since it is not, output a message saying so.
                Console.WriteLine("Tht is not a valid entry");
                Console.WriteLine("PLease make a valid choice");
                Console.WriteLine();

                //re-display the menu in case the user forgot what they could do.
                staticUserInterface.printMenu();

                //re-get the input from the user.
                input = Console.ReadLine();
            }
            //At this point, the input is valid, so we can ewturn the parse of it.
            return Int32.Parse(input);
        }

        public static void PrintAllOutput(string alloutput)
        {
            Console.WriteLine(alloutput);
        }

        private static void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");


        }
    }
}
