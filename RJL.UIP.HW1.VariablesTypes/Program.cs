using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW1.VariablesTypesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task#1
            int sideA = 10;
            int sideB = 20;
            double square = sideA * sideB;
            double perimeter = 2 * (sideA + sideB);

            Console.WriteLine("task#1\na= " + sideA + "; b= " + sideB);
            Console.WriteLine("Square of rectangle is " + square);
            Console.WriteLine("Perimetr of rectangle is " + perimeter + "\n");
            //task#2
            int radius = 10;
            double pi = 3.14;
            double lenCircle = 2 * pi * radius;
            double sqCircle = pi * radius * radius;

            Console.WriteLine("task#2\nradius= " + radius);
            Console.WriteLine("Length of circle is " + lenCircle);
            Console.WriteLine("Square of circle is " + sqCircle + "\n");
            //task#3
            int a1 = 10;
            int b1 = 20;
            double average = (a1 + b1) / 2;

            Console.WriteLine("task#3\na= " + a1 + "; b= " + b1);
            Console.WriteLine("Arithmetic average is " + average + "\n");

            //task#4
            int a2 = 10;
            int b2 = 20;
            double geometric = Math.Sqrt(a2 * b2);

            Console.WriteLine("task#4\na= " + a2 + "; b= " + b2);
            Console.WriteLine("Geometric mean is " + geometric + "\n");
            //task#5
            int c1 = 10;
            int c2 = 20;
            double distance = Math.Abs(c1 - c2);

            Console.WriteLine("task#5\nx1= " + c1 + "; x2= " + c2);
            Console.WriteLine("Distance is " + distance + "\n");
            //task#6
            int x1 = 10;
            int y1 = 20;
            int x2 = 30;
            int y2 = 40;
            double distA = Math.Abs(x1 - x2);
            double distB = Math.Abs(y1 - y2);
            double square2 = distA * distB;
            double perimeter2 = 2 * (distA + distB);
            Console.WriteLine("task#6\nx1= " + x1 + "; y1= " + y1 + ";\nx2= " + x2 + "; y2=" + y2);
            Console.WriteLine("Square of rectangle is " + square2);
            Console.WriteLine("Perimetr of rectangle is " + perimeter2 + "\n");
            //task#7
            int A = 10;
            int B = 20;
            int C = 30;
            int tempA = A;
            int tempB = B;
            int tempC = C;
            B = tempA;
            C = tempB;
            A = tempC;
            Console.WriteLine("task#7\nThe first values A= " + tempA + "; B= " + tempB + ";C= " + tempC);
            Console.WriteLine("The last values A= " + A + "; B= " + B + ";C= " + C);
            Console.ReadLine();
        }
    }
}
