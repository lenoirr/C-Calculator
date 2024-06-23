using Calculator.Classes;
using System;
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

        private int inputCount = 0;
        List<Number> inputList = new List<Number>();

        //private Number Result = new Number();


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
            inputList.Clear();
            resetCounts();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.DeleteLastChar();
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.NegateInput();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            Number input = new Number(UserInput.InputDisplay1);
            calcResultDisplay.Text = UserInput.ClearDisplay();
            if (addCount == 0)
            {
                inputList.Add(input);
            }
            else
            {

               
            }
            addCount++;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            // take current input and add it to the list
            Number input = new Number(UserInput.InputDisplay1);
            inputList.Add(input);

            dynamic num = 0;
            if(addCount ==1)
            {
                num = Calculations.PerformAdd(inputList);
            }
            else if (subCount ==1) 
            {
                num = Calculations.PerformSubtract(inputList);
            }
            else if (multiplyCount ==1)
            {
                num = Calculations.PerformMultiply(inputList);

            }
            else if (divideCount ==1)
            {
                num = Calculations.PerformDivide(inputList);
            }

            Number Result = new Number(num.number);
            inputList.Clear();
            resetCounts();

            calcResultDisplay.Text = UserInput.UpdateDisplay(Result);


        }
    }
}
