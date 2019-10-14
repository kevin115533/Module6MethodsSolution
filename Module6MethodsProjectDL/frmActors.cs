using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6MethodsProjectDL
{
    public partial class frmActors : Form
    {
        // Public Contsants to use
        const byte ADD = 0;
        const byte SUBTRACT = 1;
        const byte MULTIPLY = 2;
        const byte DIVIDE = 3;
        const byte MODULUS = 4;

        public frmActors()
        {
            InitializeComponent();
        }

        //Put Your method here
        public decimal MyMethod(decimal num1, decimal num2, byte option)
        {
            decimal myAnswer = 0.0m;
            if (option == 0)
            {
                myAnswer = num1 + num2;
            }
            else if (option == 1)
            {
                myAnswer = num1 - num2;
            }
            else if (option == 2)
            {
                myAnswer = num1 * num2;
            }
            else if (option == 3)
            {
                myAnswer = num1 / num2;
            }
            else if (option == 4)
            {
                myAnswer = num1 % num2;
            }

            return myAnswer;
        }


        private void ModulusButton(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOp.Text;
            szRight = txtRightOp.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = MyMethod(dLeft, dRight, MODULUS);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " % " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


        }

        private void DivisionButton(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOp.Text;
            szRight = txtRightOp.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = MyMethod(dLeft, dRight, DIVIDE);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " / " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


        }

        private void MultButton(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOp.Text;
            szRight = txtRightOp.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = MyMethod(dLeft, dRight, MULTIPLY);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " * " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


        }

        private void SubtractionButton(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOp.Text;
            szRight = txtRightOp.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = MyMethod(dLeft, dRight, SUBTRACT);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " - " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;


        }

        private void AddButton(object sender, EventArgs e)
        {
            decimal dLeft = 0.0m;
            decimal dRight = 0.0m;
            decimal dAnswer = 0.0m;
            string szLeft = "";
            string szRight = "";
            string szAnswer = "";
            string szEquation = "";

            szLeft = txtLeftOp.Text;
            szRight = txtRightOp.Text;

            dLeft = Convert.ToDecimal(szLeft);
            dRight = Convert.ToDecimal(szRight);

            dAnswer = MyMethod(dLeft, dRight, ADD);

            szAnswer = dAnswer.ToString();

            szEquation = szLeft + " + " + szRight + " = " + szAnswer;

            lblAnswer.Text = "";
            lblAnswer.Text = szEquation;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
