using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace csharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            while (state)
            {

                Console.WriteLine("Vælg en regneoperation: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                double input = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast tal 1"); //When exit is pressed, the program should close. Its not doing that.
                double t1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast tal 2");
                double t2 = Convert.ToDouble(Console.ReadLine());



                if (input == 1)
                {
                    double result = addition(t1, t2);
                    Console.WriteLine("The result is : " + result);
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (input == 2)
                {
                    double result = substraktion(t1, t2);
                    Console.WriteLine("The result is : " + result);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 3)
                {
                    double result = multiplikation(t1, t2);
                    Console.WriteLine("The result is : " + result);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 4)
                {
                    double result = division(t1, t2);
                    Console.WriteLine("The result is : " + result);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 5)
                {
                    state = false;
                }
                else
                {
                    Console.WriteLine("Unvalid input");
                }

            }



            double addition(double t1, double t2) //Skal ændre retur type og tilføje parametre
            {
                return t1 + t2;

            }

            double substraktion(double t1, double t2)
            {
                return t1 - t2;
            }

            double multiplikation(double t1, double t2)
            {
                return t1 * t2;
            }

            double division(double t1, double t2)
            {
                return t1 / t2;
            }




        }
    }
}
