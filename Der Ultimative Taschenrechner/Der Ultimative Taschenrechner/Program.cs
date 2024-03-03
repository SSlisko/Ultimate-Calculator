using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Der_Ultimative_Taschenrechner
{
    internal class Program
    {
        private static char jn;

        static void Main(string[] args)
        {
            do
            {
                float sum = 0;

                Console.WriteLine("Der Ulitmative Taschenrechner v1.0");
                Console.Write("\nZahl 1 eingeben: ");
                float n1 = (float)Convert.ToDouble(Console.ReadLine());


                Console.Write("\nOperator [+/-/:/*]\nFolgende Rechnung nur mit 1 Zahl [pi/sqrt/^y]: ");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    Console.Clear();
                    Console.Write("Zweite Zahl eingeben: ");
                    float n2 = (float)Convert.ToDouble(Console.ReadLine());

                    Console.Clear();

                    sum = n1 + n2;
                    Console.WriteLine("{0:0.00} + {1:0.00}", n1, n2);
                    Console.WriteLine("{0:0.00}", sum);
                }

                if (op == "-")
                {
                    Console.Clear();
                    Console.Write("Zweite Zahl eingeben: ");
                    float n2 = (float)Convert.ToDouble(Console.ReadLine());

                    Console.Clear();

                    sum = n1 - n2;
                    Console.WriteLine("{0:0.00} - {1:0.00}", n1, n2);
                    Console.WriteLine("{0:0.00}", sum);
                }

                if (op == ":")
                {
                    Console.Clear();
                    Console.Write("Zweite Zahl eingeben: ");
                    float n2 = (float)Convert.ToDouble(Console.ReadLine());

                    Console.Clear();

                    sum = n1 / n2;
                    Console.WriteLine("{0:0.00} : {1:0.00}", n1, n2);
                    Console.WriteLine("{0:0.00}", sum);
                }

                if (op == "*")
                {
                    Console.Clear();
                    Console.Write("Zweite Zahl eingeben: ");
                    float n2 = (float)Convert.ToDouble(Console.ReadLine());

                    Console.Clear();

                    sum = n1 * n2;
                    Console.WriteLine("{0:0.00} * {1:0.00}", n1, n2);
                    Console.WriteLine("{0:0.00}", sum);
                }


                if (op == "pi")
                {
                    sum = (float)(n1 * Math.PI);

                    Console.Clear();
                    Console.WriteLine("{0:0.00}pi", n1);
                    Console.WriteLine("{0:0.00}", sum);
                }


                else if (op == "sqrt")
                {
                    sum = (float)Math.Sqrt(n1);
                    Console.Clear();
                    Console.WriteLine("Wurzel({0:0.00})", n1);
                    Console.WriteLine("{0:0.00}", sum);
                }

                else if (op == "^y")
                {
                    Console.Clear();
                    Console.Write("Potenz: ");
                    double pow = Convert.ToDouble(Console.ReadLine());
                    sum = (float)Math.Pow(n1, pow);
                    Console.Clear();
                    Console.WriteLine("{0:0.00}^{1:0.00}", n1, pow);
                    Console.WriteLine("{0:0.00}", sum);
                }
                Console.Write("Noch eine berechnung durchführen? [j/n] ");
                jn = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\nBeliebige Taste drücken...");
                Console.ReadKey();
                Console.Clear();
            } while (jn == 'j');
                
        }
    }
}
