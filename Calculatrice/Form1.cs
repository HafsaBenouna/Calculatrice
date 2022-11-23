using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double aide;
        char op;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnplusmoins_Click(object sender, EventArgs e)
        {
            aide = (double.Parse(txtresultat.Text)) * (-1); 
            txtresultat.Text = aide.ToString();
        }

        private void btnvirgule_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        { 
            /*      if(txtresultat.Text == "0") 
                txtresultat.Text = "8"; 
            else         */
            txtresultat.Text = txtresultat.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultat.Text = txtresultat.Text + "9";
        }

        private void btnaddition_Click(object sender, EventArgs e)
        {
            aide = double.Parse(txtresultat.Text);
            op = '+';
            txtresultat.Text = "0";
        }

        private void btnsoustraction_Click(object sender, EventArgs e)
        {
            aide = double.Parse(txtresultat.Text);
            op = '-';
            txtresultat.Text = "0";
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            aide = double.Parse(txtresultat.Text);
            op = '*';
            txtresultat.Text = "0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            aide = double.Parse(txtresultat.Text);
            op = '/';
            txtresultat.Text = "0";
        }

        private void btnun_surx_Click(object sender, EventArgs e)
        {
            aide = 1 / (double.Parse(txtresultat.Text)) ;
            txtresultat.Text = aide.ToString();
        }

        private void btncarré_Click(object sender, EventArgs e)
        {
           
            aide = (double.Parse(txtresultat.Text)) * (double.Parse(txtresultat.Text));
            txtresultat.Text = aide.ToString();
        }
        private void btnracine_Click(object sender, EventArgs e)
        {
            aide = Math.Sqrt(double.Parse(txtresultat.Text));
            txtresultat.Text = aide.ToString();
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
            if(op == '+')
            {
                aide = aide + double.Parse(txtresultat.Text);
                txtresultat.Text = aide.ToString() ;
            }
            if (op == '-')
            {
                aide = aide -double.Parse(txtresultat.Text);
                txtresultat.Text = aide.ToString();
            }
            if (op == '*')
            {
                aide = aide *double.Parse(txtresultat.Text);
                txtresultat.Text = aide.ToString();
            }
            if (op == '/')
            {
                if (txtresultat.Text == "0")
                {
                    txtresultat.Text = "ERREUR !";
                } 
                
                else
                {
                    aide = aide / double.Parse(txtresultat.Text);
                    txtresultat.Text = aide.ToString();

                }  
                
            }
        }

        private void txtresultat_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
