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

                Console.WriteLine("Indtast tal 1");
                double t1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Indtast tal 2");
                double t2 = Convert.ToDouble(Console.ReadLine());

                

                if (input == 1)
                {
                    double result = addition(t1, t2);
                    Console.WriteLine("Resultatet er: " + result);
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (input == 2)
                {
                    //subtraktion();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 3)
                {
                    // multiplikation();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 4)
                {
                    //division();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == 5)
                {
                    state = false;
                }
                else
                {
                    Console.WriteLine("Ugyldigt input");
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

            //static void subtraktion()
            //{
            //    Console.WriteLine("Indtast tal 1");
            //    string tal1 = Console.ReadLine();

            //    Console.WriteLine("Indtast tal 2");
            //    string tal2 = Console.ReadLine();

            //    double t1 = System.Convert.ToDouble(tal1);
            //    double t2 = System.Convert.ToDouble(tal2);

            //    double sum = t1 - t2;

            //    Console.WriteLine("Resultatet er: " + sum);
            //}

            //static void multiplikation()
            //{
            //    Console.WriteLine("Indtast tal 1");
            //    string tal1 = Console.ReadLine();

            //    Console.WriteLine("Indtast tal 2");
            //    string tal2 = Console.ReadLine();

            //    double t1 = System.Convert.ToDouble(tal1);
            //    double t2 = System.Convert.ToDouble(tal2);

            //    double sum = t1 * t2;

            //    Console.WriteLine("Resultatet er: " + sum);
            //}

            //static void division()
            //{
            //    Console.WriteLine("Indtast tal 1");
            //    string tal1 = Console.ReadLine();

            //    Console.WriteLine("Indtast tal 2");
            //    string tal2 = Console.ReadLine();

            //    double t1 = System.Convert.ToDouble(tal1);
            //    double t2 = System.Convert.ToDouble(tal2);

            //    double sum = t1 / t2;

            //    Console.WriteLine("Resultatet er: " + sum);
            //}


        }
    }
}
