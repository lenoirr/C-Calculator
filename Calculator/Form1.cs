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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class RyansCalculator : Form
    {
        public int addCount = 0;
        public int subCount = 0;
        public int multiplyCount = 0;
        public int divideCount = 0;

        public RyansCalculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Calculator_KeyDown);
            calcResultDisplay.Text = UserInput.InputDisplay1;
            this.AcceptButton = equalButton;
        }

            private void resetCounts()
        {
            addCount = 0;
            subCount = 0;
            multiplyCount = 0;
            divideCount = 0;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                equalButton_Click(this, EventArgs.Empty);
            }
            else
            {
                Calculator_KeyDown(this, new KeyEventArgs(keyData));
            }
            return true;
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        
       {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                Button0_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                button2_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                button3_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                button4_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                button5_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                button6_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                button7_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                button8_Click(sender, e);
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                button9_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Add)
            {
                addButton_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                equalButton_Click(sender, e);

            }
            else if (e.KeyCode == Keys.Delete)
            {
                deleteButton_Click(sender, e);

            }
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
            if (UserInput.InputDisplay1 != "0")
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
            UserInput.inputList.Clear();
            UserInput.currentCalculation = CalcType.none;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.DeleteLastChar();
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            calcResultDisplay.Text = UserInput.NegateInput(calcResultDisplay.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            UserInput.AdditionHandler();
            calcResultDisplay.Text = UserInput.InputDisplay1;
        }

        private void equalButton_Click(object sender, EventArgs e)
        
        {
            if (UserInput.currentCalculation == CalcType.none) { return; }
            UserInput.EquateHandler();
            calcResultDisplay.Text = UserInput.InputDisplay1;
        }

        private void RyansCalculator_Load(object sender, EventArgs e)
        {

        }

    }
}
