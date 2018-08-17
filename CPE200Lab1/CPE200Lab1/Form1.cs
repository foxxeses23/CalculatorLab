using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        private double val = 0;
        private double old = 0;
        int check = 0;
        
         
        public Form1()
        {
            InitializeComponent();
        }
        
        private void display()
        {
            lblDisplay.Text = val.ToString();
        }
        private void lblDisplay_Click(object sender, EventArgs e)
        {
           
        }

        private void numClick(int n)
        {
            val = val * 10 + n;
            display();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            numClick(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numClick(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numClick(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numClick(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numClick(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numClick(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numClick(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numClick(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numClick(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numClick(9);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            double v = -val;
            val = v;
            display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            val = 0;
            display();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            old = val;

            val = 0;

            check = 1;
            
            
        }   
       
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (check == 1) val = val + old;
            if (check == 2) val = old - val;
            if (check == 3) val = old * val;
            if (check == 4) val = old / val;
            display();
        }

       
        private void btnMinus_Click(object sender, EventArgs e)
        {
            old = val;

            val = 0;

            check = 2;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            old = val;

            val = 0;

            check = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            old = val;

            val = 0;

            check = 4;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            val = val / 100; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            val = val + '.';
        }
    }
}
