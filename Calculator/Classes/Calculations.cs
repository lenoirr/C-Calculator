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

        public static dynamic PerformAdd(List<dynamic> inputList)
        {
            dynamic num;

            num = inputList[0] + inputList[1];
            Number result = new Number();
            result.NumberConverter(num);

            Console.WriteLine(result.number.GetType().Name);

            return result.number;
        }

        public static dynamic PerformSubtract(List<dynamic> inputList)
        {
            dynamic num;

            num = inputList[0].number - inputList[1].number;
            Number result = new Number();
            result.NumberConverter(num);

            Console.WriteLine(result.number.GetType().Name);

            return result.number;
        }

        public static dynamic PerformMultiply(List<dynamic> inputList)
        {
            dynamic num;

            num = inputList[0].number * inputList[1].number;
            Number result = new Number();
            result.NumberConverter(num);

            Console.WriteLine(result.number.GetType().Name);

            return result.number;
        }

        public static dynamic PerformDivide(List<dynamic> inputList)
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

            Number result = new Number();
            result.NumberConverter(num);

            Console.WriteLine(result.number.GetType().Name);

            return result.number;
        }
    }
}
