using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
    public class DoubleCalculator:AbstractCalculator<double>
    {
        public override double Add(double input1, double input2)
        {
            return input1 + input2;
        }
        public override double Sub(double input1, double input2)
        {
            return input1 - input2;
        }

        public override double Multiply(double input1, double input2)
        {
            return input1 * input2;
        }


        public override double Divide(double input1, double input2)
        {
            while (input2 == 0)
            {
                Console.WriteLine("In division the Second Number should not be 0");
                Console.Write("Enter another number:");
                input2 = Convert.ToDouble(Console.ReadLine());
            }
            return input1 / input2;
        }

        public override double multipleAdd(params double[] num)
        {
            double c = 0;
            foreach (double i in num)
            {
                c = c + i;
                
            }
            
            return c;
        }
    }
}
