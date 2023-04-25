using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Initialization of data

            int numOfIngr = 0;

            List<string> ingrNames = new List<string>();
            List<double> ingrQuant = new List<double>();
            List<string> ingrUnits = new List<string>();

            int numOfSteps = 0;

            List<string> steps = new List<string>();


            // Main loop


            while (true)
            {
                Console.WriteLine("Choose an option:\n1. Enter recipe details\n2. Display recipe\n3. Scale recipe\n4. Reset quantities\n5. Clear all data\n6. Exit");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        // prompting user to enter data

                        Console.WriteLine("Enter number of ingredients:");
                        numOfIngr = int.Parse(Console.ReadLine());

                        ingrNames.Clear();
                        ingrQuant.Clear();
                        ingrUnits.Clear();

                        for (int i = 1; i <= numOfIngr; i++)
                        {
                            Console.WriteLine($"Ingredient {i}:");
                            Console.WriteLine("Name:");
                            ingrNames.Add(Console.ReadLine());
                            Console.WriteLine("Quantity:");
                            ingrQuant.Add(double.Parse(Console.ReadLine()));
                            Console.WriteLine("Unit of measurement:");
                            ingrUnits.Add(Console.ReadLine());
                        }

                        Console.WriteLine("Enter number of steps:");
                        numOfSteps = int.Parse(Console.ReadLine());

                        steps.Clear();

                        for (int i = 1; i <= numOfSteps; i++)
                        {
                            Console.WriteLine($"Step {i}:");
                            steps.Add(Console.ReadLine());
                        }
                        break;

                    case "2":

                        // Display recipe

                        Console.WriteLine("\nRecipe:\n");

                        for (int i = 0; i < numOfIngr; i++)
                        {
                            Console.WriteLine($"{ingrQuant[i]} {ingrUnits[i]} of {ingrNames[i]}");
                        }

                        Console.WriteLine("\nSteps:");

                        for (int i = 0; i < numOfSteps; i++)
                        {
                            Console.WriteLine($"{i + 1}. {steps[i]}");
                        }
                        break;

                    case "3":

                        // Scale recipe

                        Console.WriteLine("Enter scaling factor (0.5, 2, or 3):");
                        double factor = double.Parse(Console.ReadLine());

                        for (int i = 0; i < numOfIngr; i++)
                        {
                            ingrQuant[i] *= factor;
                        }
                        break;

                    case "4":
                        // Reset option for quantities

                        for (int i = 0; i < numOfIngr; i++)
                        {
                            ingrQuant[i] /= 2;
                        }
                        break;

                    case "5":

                        // Clearing Data

                        numOfIngr = 0;
                        ingrNames.Clear();
                        ingrQuant.Clear();
                        ingrUnits.Clear();
                        numOfSteps = 0;
                        steps.Clear();
                        break;

                    case "6":

                        // Exiting program

                        return;

                    default:
                        Console.WriteLine("Option invalid.");
                        break;
                }
            }
        }



    }
}

