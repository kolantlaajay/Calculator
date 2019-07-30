using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
    public class IntCalculator:AbstractCalculator<int>
    {
        public override int Add(int input1, int input2)
        {
            return input1 + input2;
        }

        public override int Sub(int input1, int input2)
        {
            return input1 - input2;
        }

        public override int Multiply(int input1, int input2)
        {

            return input1 * input2;
        }

        public override int Divide(int input1, int input2)
        {
            while (input2 == 0)
            {
                Console.WriteLine("In division the Second Number should not be 0");
                Console.Write("Enter another number:");
                input2 = Convert.ToInt32(Console.ReadLine());
            }
            return input1/input2;
            
            
        }

        public override int multipleAdd(params int[] num)
        {
            int c = 0;
            foreach (int i in num)
            {
                c = c + i;
            }
            return c;
        }
    }
}
