using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal class Number
    {
        private string inputString;
        private static DataType dataType;
        public dynamic number;              // type will be dynamically set based on inputstring passed. 

        public void NumberConverter(string inputString)
        {
            this.inputString = inputString;

            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException("input is null or empty");
            }
            else
            {
                if (inputString.Contains('.'))
                {
                    dataType = DataType.doubleType;
                    double.TryParse(inputString, out double num);
                    number = num;
                }
                else
                {
                    dataType = DataType.intType;
                    int.TryParse(inputString, out int num);
                    number = num;
                }
            }
        }

        public void NumberConverter(int number)
        {
            this.number = number;
            dataType = DataType.intType;
        }

        
        public void NumberConverter(double number)
        {
            this.number = number;
            dataType = DataType.doubleType; 
        }
        public override string ToString()
        {
            //return $"Input String: {inputString}, Is Negative: {isNegative}, Length: {length}, Data Type: {number.GetType().Name}, Number: {number}";
            return $"{number}";
}
    }
}
