using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cup cup = new Cup();
            cup.Colour = "Red";
            cup.Handle = "Small";
            cup.DisplayCup();

            double v1 = 100, v2 = 100;
            double res;

            Circuit cir = new Circuit();

            res = cir.Parallel(v1, v2);
            Console.WriteLine("Parallel resistance is {0} ohms", res);

            res = cir.Series(100, 100);
            Console.WriteLine("Series resistance is {0} ohms", res);

            string str;
            double mag, angle;
            Complex r = new Complex();

            Console.Write("Enter real value >> ");
            str = Console.ReadLine();
            r.real = Convert.ToInt32(str);

            Console.Write("Enter imag value >> ");
            str = Console.ReadLine();
            r.imag = Convert.ToInt32(str);

            mag = r.mag();
            angle = r.angle();
            Console.WriteLine("Mag is {0} and angle is {1}", mag, angle);

            Console.ReadLine();
        }
    }

    public class Cup
    {
        public string Shape;
        public string Colour;
        public string Size;
        public int Transparency;
        public string Handle;

        public void DisplayCup()
        {
            System.Console.WriteLine("Cup is {0}, {1}", Colour, Handle);
        }
    }

    public class Circuit
    {
        public double Parallel (double r1, double r2)
        {
            return ((r1 * r2) / (r1 + r2));
        }
        public double Series (double r1, double r2)
        {
            return (r1 + r2);
        }
    }

    public class Complex
    {
        public double real;
        public double imag;

        public double mag()
        {
            return (Math.Sqrt(real * real + imag * imag));
        }
        public double angle()
        {
            return (Math.Atan(imag / real) * 180 / Math.PI);
        }
    }
}
