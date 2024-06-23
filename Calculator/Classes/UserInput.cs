using Calculator.Classes;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    // This class will format and display the input and results from the user

    // TODO: Limit input to the available viewing size of the input number on the calculator. - So keep clicking doesn't work. 
    // Create input class to track length, required percision, etc. 
    internal static class UserInput
    {
        private static bool inputIsNegative = false;
        private static string inputDisplay1 = "0";
        private static string outputDisplay = null;
        private static DataType dataType;


        public static string InputDisplay1
        {
            get { return inputDisplay1; } private set { inputDisplay1 = value; }
        }

        public static string OutputDisplay
        {
            get { return outputDisplay; } private set { outputDisplay = value; }
        }

        public static string UpdateDisplay(char num)
        {
            if (InputDisplay1 == "0")
            {
                EmptyDisplay();
            }
                InputDisplay1 += num;
                return InputDisplay1;
        }

        public static string UpdateDisplay(Number number)
        {
            InputDisplay1 = number.ToString();
            return InputDisplay1;
        }


        public static string ClearDisplay()
        {
            InputDisplay1 = string.Empty;
            InputDisplay1 = "0";
            return InputDisplay1;
        }

        public static string EmptyDisplay()
        {
            InputDisplay1 = string.Empty;
            return InputDisplay1;
        }

        public static string DeleteLastChar()
        {

            if (InputDisplay1 != "0")
            {
                if ((InputDisplay1.Length == 2 & inputIsNegative) || InputDisplay1.Length == 1)
                {
                    ClearDisplay();
                }
                else
                {
                    InputDisplay1 = InputDisplay1.Remove(InputDisplay1.Length - 1);
                }
            }
            return InputDisplay1;
        }

        public static string NegateInput()
        {
            if (InputDisplay1 == "0")
            {
                return InputDisplay1;
            }
            if (inputIsNegative)
            {
                InputDisplay1 = InputDisplay1.Substring(1);
                inputIsNegative = false;
            }
            else
            {
                InputDisplay1 = "-" + InputDisplay1;
                inputIsNegative = true;
            }
            return InputDisplay1;
        }
        
        static void FunctionButton(CalcType function)
        {
            switch (function)
            {
                case CalcType.addition:
                    // Perform action for Zero
                    break;
                case CalcType.subtract:
                    // Perform action for One
                    break;
                case CalcType.multiply:
                    // Perform action for Two
                    break;
                case CalcType.divide:
                    // Perform action for Three
                    break;
                default:
                    // Handle invalid function
                    break;
            }
        }

    }
}
