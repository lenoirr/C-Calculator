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
        //private static bool inputIsNegative = false;
        private static string inputDisplay1 = "0";
        private static DataType dataType;
        public static bool resultDisplaying;   // tracks wether a calc result is being display - determines if input should be cleared or not.

        private static int inputCount = 0;
        public static List<dynamic> inputList = new List<dynamic>();
        public static List<dynamic> lastInputList = new List<dynamic>();

        public static CalcType currentCalculation = CalcType.none;
        public static CalcType lastCalulation = CalcType.none;

        public static string InputDisplay1
        {
            get { return inputDisplay1; } private set { inputDisplay1 = value; }
        }


        public static string UpdateDisplay(char num)
        {
            if (resultDisplaying)
            {
                EmptyDisplay();
                resultDisplaying = false;
            }
            if (InputDisplay1 == "0")
            {
                EmptyDisplay();
            }

            InputDisplay1 += num;
                return InputDisplay1;
        }


        public static string UpdateDisplay(Number number)
        {
            if (resultDisplaying) { resultDisplaying = false; }
            
            InputDisplay1 = number.ToString();
            //currentCalculation = CalcType.none;
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
            bool inputIsNegative = IsNegative();

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

        public static string NegateInput(string val)
        {
            bool inputIsNegative = IsNegative();
            if (val == "0")
            {
                return val;
            }
            if (inputIsNegative)
            {
                val = val.Substring(1);
            }
            else
            {
                val = "-" + val;
            }
            inputDisplay1 = val;
            return inputDisplay1;
        }
        
        public static bool IsNegative()
        {
            return InputDisplay1.Contains('-');
        }
        public static void UpdateInputList()
        {
            Number lastInput = new Number();
            lastInput.NumberConverter(InputDisplay1);
            inputList.Add(lastInput.number);
            lastInputList.Add(lastInput.number);

        }
        public static void ClearInputList()
        {
            lastInputList = new List<dynamic>(inputList);
            inputList.Clear();
        }
        public static void AdditionHandler ()
        {
            if (inputList.Count < 2)    // if not pressed 
            {
                
            
                if (currentCalculation == CalcType.none || currentCalculation == CalcType.equate)    // 1 + type handler
                {
                    UpdateInputList();  // should fill inputList[0]
                    ClearDisplay();     // TODO: I have to finish this outside of the function
                    currentCalculation = CalcType.addition;
                }
                else // 1+ 1 = 2 + type handler with any other calculation type
                {
                    EquateHandler();
                    UpdateInputList();
                    currentCalculation = CalcType.addition;
                }
            }
    }

        public static void SubtractionHandler()
        {
            if (inputList.Count < 2)
            {
                if (currentCalculation == CalcType.none || currentCalculation == CalcType.equate)
                {
                    UpdateInputList();
                    ClearDisplay();
                    currentCalculation = CalcType.subtract;
                }
                else
                {
                    EquateHandler();
                    UpdateInputList();
                    currentCalculation = CalcType.subtract;
                }
            }
        }

        public static void MultiplicationHandler()
        {
            if (inputList.Count < 2)
            {
                if (currentCalculation == CalcType.none || currentCalculation == CalcType.equate)
                {
                    UpdateInputList();
                    ClearDisplay();
                    currentCalculation = CalcType.multiply;
                }
                else
                {
                    EquateHandler();
                    UpdateInputList();
                    currentCalculation = CalcType.multiply;
                }
            }
        }

        public static void DivisionHandler()  
        {
            if (inputList.Count < 2)
            {
                if (currentCalculation == CalcType.none || currentCalculation == CalcType.equate)
                {
                    UpdateInputList();
                    ClearDisplay();
                    currentCalculation = CalcType.divide;
                }
                else
                {
                    EquateHandler();
                    UpdateInputList();
                    currentCalculation = CalcType.divide;
                }
            }
        }

        public static void EquateHandler()
        {
            Number result = new Number();   // creates null instance of result;

            List<dynamic> processData = new List<dynamic>();

            //bool repeatCalculation;

            CalcType calcToPerform = CalcType.none;

            if (resultDisplaying)   // repeat last calculation
            {
                //repeatCalculation = true;
                UpdateInputList();
                inputList.Add(lastInputList[1]);
                calcToPerform = lastCalulation;
            }
            else if (currentCalculation != CalcType.none && inputList.Count == 1)   // perform current calculation
            {
                //repeatCalculation = false;
                UpdateInputList();
                calcToPerform = currentCalculation;

            }
            else { return; }    // why you pressing this right now?

            switch (calcToPerform) // TODO: This typing for Number is not ideal
            {
                case CalcType.addition:
                    result.NumberConverter(Calculations.PerformAdd(inputList));
                    break;
                case CalcType.subtract:
                    result.NumberConverter(Calculations.PerformSubtract(inputList));
                    break;
                case CalcType.multiply:
                    result.NumberConverter(Calculations.PerformMultiply(inputList));
                    break;
                case CalcType.divide:
                    result.NumberConverter(Calculations.PerformDivide(inputList));
                    break;
                default:
                    break;
            }

            UpdateDisplay(result);   // still have to update this outside of the function
            ClearInputList();
            if (currentCalculation != CalcType.none)
            {
                lastCalulation = currentCalculation;
            }
            currentCalculation = CalcType.none;
            resultDisplaying = true;

        }


    }
}
