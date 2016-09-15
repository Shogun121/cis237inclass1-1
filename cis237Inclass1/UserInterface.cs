using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class UserInterface
    {
        /// <summary>
        /// There are no backing field variables because we don't need any.
        /// There are no properties because we don't have any backing fields.
        /// There are also, no constructors. We will just use the default that is automatically provided to us.
        /// 
        /// This class essentialy becomes a collection of methods that do work.
        /// 
        /// Get user input.
        /// </summary>
        /// <returns></returns>
        public int GetUserInput()
        {   //Call the printMenu method that is private to the class.
            this.printMenu();

            //Get the input from the console.
            string input = Console.ReadLine();

            //Contime to loop while th einput is not a valid choice.
            while(input!= "1" && input !="2")
            {
                //Since it is not, output a message saying so.
                Console.WriteLine("Tht is not a valid entry");
                Console.WriteLine("PLease make a valid choice");
                Console.WriteLine();

                //re-display the menu in case the user forgot what they could do.
                this.printMenu();

                //re-get the input from the user.
                 input = Console.ReadLine();
            }
            //At this point, the input is valid, so we can ewturn the parse of it.
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
