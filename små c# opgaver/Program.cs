using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_7_basic_CSharp
{
    class Program
    {
        static void Main(string[] args) //inskrives øvelser når de skal køres, ekempel kan ses Under 
        {
            Console.WriteLine("Her visses alle opgaver fra skal-opgaver; opgave 7");
            øvelse14();

        }
        static void øvelse1()
        {
            Console.WriteLine("martin");
            Console.WriteLine("");
            Console.WriteLine("Egeskov");
            return;
        }

        static void øvelse2()
        {
            Console.WriteLine(1 - 2);

        }

        static void øvelse3()
        {
            Console.WriteLine(10 / 27);

        }

        static void øvelse4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        static void øvelse5() //opret viabler, kontakt brugeren, inskrivelse af indformationen.
        {
            int Num1, Num2;
            Console.WriteLine("skriv et tal her");
            Num1 = int.Parse(Console.ReadLine()); //[int.parse] converting user input value(which is a string) in to a integer.
            Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Num2);
            Console.WriteLine(Num1);
        }
        static void øvelse5d2() //skulle lige prøve at gøre det samme som i opgave 5 bare med sættninger
        {
            string num1, num2;
            Console.WriteLine("skriv en sætning her");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            Console.WriteLine(num2);
            Console.WriteLine(num1);

        }
        static void øvelse6()
        {
            int num1, num2;

            Console.WriteLine("skriv dit tal her");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
        }
        static void øvelse7()
        {
            int num1, num2;
            Console.WriteLine("skriv dine tal her");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
        }
        static void øvelse8()
        {
            int num1;
            Console.WriteLine("skriv did tal her");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine(num1 * 1);
            Console.WriteLine(num1 * 2);
            Console.WriteLine(num1 * 3);
            Console.WriteLine(num1 * 4);
            Console.WriteLine(num1 * 5);
            Console.WriteLine(num1 * 6);
            Console.WriteLine(num1 * 7);
            Console.WriteLine(num1 * 8);
            Console.WriteLine(num1 * 9);
            Console.WriteLine(num1 * 10);
        }
        static void øvelse9()
        {
            int num1, num2, num3, num4;
            Console.WriteLine("skriv dine tal her");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2 + num3 + num4) / 4);
        }
        static void øvelse10()
        {
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            Console.WriteLine((x + y) * z);
            Console.WriteLine(x * y + y * z);
        }
        static void øvelse11()
        {
            int alder;
            Console.WriteLine(" hvor gammel er du ");
            alder = int.Parse(Console.ReadLine());
            Console.WriteLine("du ser ældrer ud end {0} ", alder);
        }
        static void øvelse12() //viser forskellen mellem writeline som skriver en ny linje og write der laver et mellemrum
        {
            int x;
            Console.WriteLine("skriv dit tal her");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write(x);
            Console.Write(" ");
            Console.Write(x);
            Console.Write(" ");
            Console.Write(x);
            Console.Write(" ");
            Console.Write(x);
            Console.WriteLine(" ");

            //anden del
            Console.Write(x);
            Console.Write(x);
            Console.Write(x);
            Console.Write(x);

            //trejde del
            Console.Write("{0}{0}{0}{0}", x);
        }
        static void øvelse13()
        {
            int x;
            Console.WriteLine("skriv et tal her");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("{0}{0}{0}", x);
            Console.Write(x);
            Console.Write(" ");
            Console.Write(x);
            Console.WriteLine(" ");
            Console.Write(x);
            Console.Write(" ");
            Console.Write(x);
            Console.WriteLine(" ");
            Console.WriteLine("{0}{0}{0}", x);
        }
        public static void øvelse14()
        {
            int TC;
            Console.WriteLine("hvor varmt/koldt er det udenfor i *C ");
            TC = int.Parse(Console.ReadLine()); //TC står for Tempratur  i cellius
            Console.WriteLine("så er det Kelvin = {0}", TC + 273);
            Console.WriteLine("og Fahrenheit = {0}", TC * 18 / 10 + 32);
        }
    }
}

