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
    public partial class calculator : Form
    {
        private double val = 0;
        private string operatorsign = "";
        private bool operatorClicked = false;

        internal double Value
        {
            get { return val; } 
            set { val = value; }
        }
        internal string Operator
        {
            get { return operatorsign; }
            set { operatorsign = value; }
        }
        internal bool OperatorClicked
        {
            get { return operatorClicked; }
            set { operatorClicked = value; }
        }

        public calculator()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0")||(OperatorClicked))
                txtDisplay.Clear();


            OperatorClicked = false;
            Button NumBtn = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + NumBtn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            try{

                Button OperatorBtn = (Button)sender;
                Operator = OperatorBtn.Text;
                Value = Double.Parse(txtDisplay.Text);
                OperatorClicked = true;

            }
            catch (Exception ex) { txtDisplay.Text = "Error!" + ex; }
            

        }



        private void EqualButton_Clicked(object sender, EventArgs e)
        {

                switch (Operator)
                {

                    case "+":
                        txtDisplay.Text = (Value + Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (Value - Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (Value * Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "/":
                        txtDisplay.Text = (Value / Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    case "%":
                        txtDisplay.Text = ((Value) * (Double.Parse(txtDisplay.Text) / 100)).ToString();
                        break;
                }


        }
    }
}
