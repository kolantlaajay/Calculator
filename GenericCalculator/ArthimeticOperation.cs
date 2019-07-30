using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCalculator
{
    public class ArthimeticOperation<T>
    {
        public AbstractCalculator<T> myCalculator;
        public ArthimeticOperation(AbstractCalculator<T> myCalculator)
        {
            this.myCalculator = myCalculator;
        }

        public T summation(T input1,T input2)
        {
            dynamic sum = myCalculator.Add(input1,input2);
            return sum;

        }

        public T subract(T input1, T input2)
        {
            dynamic sub = myCalculator.Sub(input1, input2);
            return sub;
        }

        public T divide(T input1,T input2)
        {
            dynamic div = myCalculator.Divide(input1, input2);
            return div;
        }

        public T multiply(T input1,T input2)
        {
            dynamic mul = myCalculator.Multiply(input1, input2);
            return mul;
        }

        
    }
}
