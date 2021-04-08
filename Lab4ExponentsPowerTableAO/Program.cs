using System;

namespace Lab4ExponentsPowerTableAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Exponents Power Table");

            bool runProgram = true;
            do
            {
                Console.WriteLine("Enter a number: ");

                int p = int.Parse(Console.ReadLine());
                CountUp(p);

               
                static void CountUp(int p)
                {

                    for (int i= 1; i <= p; i++)
                    {
                        Console.WriteLine("Number " +"\t" + "Squared" + "\t"+"Cubed");
                        Console.WriteLine(i + "\t" + Squared(i) + "\t" + Cubed(i));
                    } 
                    if (p <= 0)
                    {
                        Console.WriteLine("Please select a positive number greater than 0.");
                    } 
                    else if (p > 1290)
                    {
                        Console.WriteLine("Please select a smaller number.");
                    } 
                }


                static int Squared(int p)
                {
                    return p * p;
                }

                static int Cubed(int p)
                {
                    return p * p * p;
                }

                Console.WriteLine("Do you want to continue y/n? ");

                while (true)
                {
                    string result = Console.ReadLine();
                    if (result == "y")
                    {
                        break;// Continue program
                    }
                    else if (result == "n")
                    {
                        runProgram = false;
                        break;// End program 
                    }
                    else
                    {
                        Console.WriteLine("That was not a y/n");
                    }


                }
            } while (runProgram);
        }
    }
}