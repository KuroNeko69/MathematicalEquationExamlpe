using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadraticEquationLib;

namespace QuadraticEquationNamespace
{
    class Program
    {

        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(System.Console.ReadLine());
            b = double.Parse(System.Console.ReadLine());
            c = double.Parse(System.Console.ReadLine());
            QuadraticEquation qe = new QuadraticEquation(a, b, c);
            double delta = qe.calculateDelta();
            System.Console.WriteLine("Delta = " + delta);
            if(delta <0)
            {
                System.Console.WriteLine("No solutions.");
            } else if(delta == 0)
            {
                System.Console.WriteLine("X = " + qe.calculateX0());
            } else
            {
                System.Console.WriteLine("X1 = " + qe.calculateX1());
                System.Console.WriteLine("X2 = " + qe.calculateX2());
            }

            System.Console.ReadLine();
        }
    }
}
