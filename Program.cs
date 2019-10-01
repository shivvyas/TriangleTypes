using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodologies_Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ValidateMenu();
            Console.ReadKey();

        }

       public static int ValidateMenu()
        {
            string  C = " ";
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            bool validMenu = false;
            //TriangleSolver ts = new TriangleSolver();

            while (validMenu == false)
            {
                Console.WriteLine("\n\tMENU: ");
                Console.WriteLine("1. Enter triangle dimensions ");
                Console.WriteLine("2. Exit ");
                Console.WriteLine("\nEnter your choice by entering a number[1/2]: ");
                C = Console.ReadLine();

                if (C != "1" && C != "2")
                {
                    Console.WriteLine("That's not a valid menu option, please try again:\n");
                }

                else
                {
                    switch (C)
                    {
                        case "1":

                            s1 = ValidateInput("First side");
                            
                            s2 = ValidateInput("Second side");
                           
                            s3 = ValidateInput("Third side");

                                TriangleSolver.Analyze(s1, s2, s3);
                            break;

                        case "2":
                            System.Environment.Exit(exitCode: 'e');
                            break;

                        default:
                            Console.WriteLine("Select valid number.");
                            break;
                    }
                }
            }
            Console.WriteLine();
            return int.Parse(C);


        }
        public static int ValidateInput(string tside)
        {
            int num = 1;
            bool isValid = false;

            do
            {
                Console.WriteLine("Please enter the {0} of your triangle: ", tside);
                string uInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(uInput, out num);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again: \n");
                }
                else if (num <= 0)
                {
                    Console.WriteLine("Number can not be less than 0, Please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {tside} of your triangle is now {num} \n");
                }

            } while (isValid == false);
            return (num);
        }
    }
}
