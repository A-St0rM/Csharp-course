using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace csharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vælg en regneoperation: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string valg = Console.ReadLine();

            userInput();

            if (valg == "1")
            {
                addition();
            }
            else if (valg == "2")
            {
                subtraktion();
            }
            else if (valg == "3")
            {
                multiplikation();
            }
            else if (valg == "4")
            {
                division();
            }

            
            static void userInput()
            {
                Console.WriteLine("Indtast tal 1");
                string tal1 = Console.ReadLine();

                Console.WriteLine("Indtast tal 2");
                string tal2 = Console.ReadLine();

                double t1 = System.Convert.ToDouble(tal1);
                double t2 = System.Convert.ToDouble(tal2);
            }

            static double addition() //Skal ændre retur type og tilføje parametre
            {             
                return sum = t1 + t2;
                Console.WriteLine("Resultatet er: " + sum);
            }

            static void subtraktion()
            {
                Console.WriteLine("Indtast tal 1");
                string tal1 = Console.ReadLine();

                Console.WriteLine("Indtast tal 2");
                string tal2 = Console.ReadLine();

                double t1 = System.Convert.ToDouble(tal1);
                double t2 = System.Convert.ToDouble(tal2);

                double sum = t1 - t2;

                Console.WriteLine("Resultatet er: " + sum);
            }

            static void multiplikation()
            {
                Console.WriteLine("Indtast tal 1");
                string tal1 = Console.ReadLine();

                Console.WriteLine("Indtast tal 2");
                string tal2 = Console.ReadLine();

                double t1 = System.Convert.ToDouble(tal1);
                double t2 = System.Convert.ToDouble(tal2);

                double sum = t1 * t2;

                Console.WriteLine("Resultatet er: " + sum);
            }

            static void division()
            {
                Console.WriteLine("Indtast tal 1");
                string tal1 = Console.ReadLine();

                Console.WriteLine("Indtast tal 2");
                string tal2 = Console.ReadLine();

                double t1 = System.Convert.ToDouble(tal1);
                double t2 = System.Convert.ToDouble(tal2);

                double sum = t1 / t2;

                Console.WriteLine("Resultatet er: " + sum);
            }


        }
    }
}
