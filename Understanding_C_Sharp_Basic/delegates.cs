﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_C_Sharp_Basic
{
    // Declare delegate -- defines required signature:
    delegate double MathAction(double num);   // public double Multiplication(double num)

    class DelegateTest
    {
        // Regular method that matches signature:    // double multiByTwo() 
        static double Double(double input)
        {
            input *= 100;

            return input * 2;
        }

        static void Main()
        {
            // Instantiate delegate with named method:
            MathAction ma = Double;

            // Invoke delegate ma:
            double multByTwo = ma(4.5);
            Console.WriteLine("multByTwo: {0}", multByTwo);

            // Instantiate delegate with anonymous method:
            MathAction ma2 = delegate (double input)
            {
                return input * input;
            };

            double square = ma2(5);
            Console.WriteLine("square: {0}", square);

            // Instantiate delegate with lambda expression
            MathAction ma3 = s => s * s * s;
            double cube = ma3(4.375);

            Console.WriteLine("cube: {0}", cube);

            Console.ReadKey();
        }
        // Output:
        // multByTwo: 9
        // square: 25
        // cube: 83.740234375

        
    }
}
