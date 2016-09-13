using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.FirstName = "Robert";
            myEmployee.LastName = "Cooley";
            myEmployee.WeeklySalary = 2048.54m;

            Console.WriteLine(myEmployee.FirstName);
            Console.WriteLine(myEmployee);

            Employee[] employees = new Employee[10];    //Create an array

            employees[0] = new Employee("James", "Kirk", 453.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 200m);
            employees[2] = new Employee("Benjamin", "Sisko", 190.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 897.00m);
            employees[4] = new Employee("Johnathan", "Archer", 425.00m);

            foreach (Employee employee in employees)
            {
                if(employee != null)
                {
                    Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());
                }
                
            }
            UserInterface ui = new UserInterface();

            int choice = ui.GetUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string allOutput = "";

                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            allOutput += employee.ToString()
                                      + " " + employee.YearlySalary()
                                      + Environment.NewLine;
                        }
                    }
                    ui.PrintAllOutput(allOutput);
                }
                choice = ui.GetUserInput();
            }
        }
    }
}
