using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class UserInterface
    {
        public int GetUserInput()
        {   //Get input from user, use to make choices
            this.printMenu();

            string input = Console.ReadLine();

            while(input!= "1" && input !="2")
            {
                Console.WriteLine("Tht is not a valid entry");
                Console.WriteLine("PLease make a valid choice");
                Console.WriteLine();

                this.printMenu();

                 input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        public void PrintAllOutput(string alloutput)
        {
            Console.WriteLine(alloutput);
        }

        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
            

        }
    }
}
