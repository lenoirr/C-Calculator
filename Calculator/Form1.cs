using Calculator.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class RyansCalculator : Form
    {
        public int addCount = 0;
        public int subCount = 0;
        public int multiplyCount = 0;
        public int divideCount = 0;



        private CalcType currentCalculation;

        public RyansCalculator()
        {
            InitializeComponent();
            calcResultDisplay.Text = UserInput.InputDisplay1;
        }
        private void resetCounts()
        {
            addCount = 0;
            subCount = 0;
            multiplyCount = 0;
            divideCount = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('9');
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (UserInput.InputDisplay1 !="0")
            {
                calcResultDisplay.Text = UserInput.UpdateDisplay('0');
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.UpdateDisplay('.');
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.ClearDisplay();
        }
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.ClearDisplay();
            UserInput.inputList.Clear();        // TODO: create method to clear inputList instead. 
            //resetCounts();
            currentCalculation = CalcType.none;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.DeleteLastChar();
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.NegateInput(calcResultDisplay.Text);
        }

       /* private void FunctionButton(CalcType function)
        {
            
            Number lastInput = new Number(UserInput.InputDisplay1);
            calcResultDisplay.Text = UserInput.ClearDisplay();
            inputList.Add(lastInput);
            int numInputs = inputList.Count;

            dynamic result = 0;

            
                switch (function)
                {
                    case CalcType.addition:
                        currentCalculation = CalcType.addition;
                        if (numInputs > 1)
                        {
                            result = Calculations.PerformAdd(inputList);
                        }
                        break;
                    case CalcType.subtract:
                        currentCalculation = CalcType.subtract;
                        if (numInputs > 1)
                        {
                            result = Calculations.PerformSubtract(inputList);
                        }
                        break;
                    case CalcType.multiply:
                        currentCalculation = CalcType.multiply;
                        if (numInputs > 1)
                        {
                            result = Calculations.PerformMultiply(inputList);
                        }
                        break;
                    case CalcType.divide:
                        currentCalculation = CalcType.divide;
                        if (numInputs > 1)
                        {
                            result = Calculations.PerformDivide(inputList);
                        }
                        break;
                    default:

                        break;
                }
            if (inputList.Count > 1)
            {

                Number Result = new Number(result.number);
                inputList.Clear();
                //resetCounts();

                inputList.Add(Result);

                //currentCalculation = CalcType.none;
                calcResultDisplay.Text = UserInput.UpdateDisplay(Result);
                UserInput.ClearDisplay();

            }
        }*/

        private void addButton_Click(object sender, EventArgs e)
        {
            UserInput.AdditionHandler();
            calcResultDisplay.Text = UserInput.InputDisplay1;

            //UserInput.UpdateDisplay(inputList[0]);

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            UserInput.EquateHandler();
            calcResultDisplay.Text = UserInput.InputDisplay1;
        }

    }
}
