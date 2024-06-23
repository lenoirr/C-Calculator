using Calculator.Classes;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Calculations
    {

        public static Number PerformAdd(List<Number> inputList)
        {
            dynamic num;

            num = inputList[0].number + inputList[1].number;
            Number result = new Number(num);

            Console.WriteLine(result.number.GetType().Name);

            return result;
        }

        public static Number PerformSubtract(List<Number> inputList)
        {
            dynamic num;

            num = inputList[0].number - inputList[1].number;
            Number result = new Number(num);

            Console.WriteLine(result.number.GetType().Name);

            return result;
        }

        public static Number PerformMultiply(List<Number> inputList)
        {
            dynamic num;

            num = inputList[0].number * inputList[1].number;
            Number result = new Number(num);

            Console.WriteLine(result.number.GetType().Name);

            return result;
        }

        public static Number PerformDivide(List<Number> inputList)
        {
            dynamic num;

            try
            {
                num = inputList[0].number / inputList[1].number;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine (ex.Message);
                throw;
            }

            Number result = new Number(num);

            Console.WriteLine(result.number.GetType().Name);

            return result;
        }
    }
}
