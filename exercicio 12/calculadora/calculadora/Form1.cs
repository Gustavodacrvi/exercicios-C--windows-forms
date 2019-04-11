using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void forButton_Click(object sender, EventArgs e)
        {
            int ipt;
            int result;

            if (Int32.TryParse(input.Text, out ipt))
            {
                for (int i=1;i<11;i++)
                {
                    result = i * ipt;
                    whileLabel.Text += "" + Convert.ToString(ipt) + " x " + Convert.ToString(i) + " = " + Convert.ToString(result) + "\n";
                }
            }
        }

        private void whileButton_Click(object sender, EventArgs e)
        {
            int ipt;
            int result;

            if (Int32.TryParse(input.Text, out ipt))
            {
                int i = 1;
                while (i < 11)
                {
                    result = i * ipt;
                    forLabel.Text += "" + Convert.ToString(ipt) + " x " + Convert.ToString(i) + " = " + Convert.ToString(result) + "\n";

                    i++;
                }
            }
        }

        private void doWhileButton_Click(object sender, EventArgs e)
        {
            int ipt;
            int result;

            if (Int32.TryParse(input.Text, out ipt))
            {
                int i = 0;
                do
                {
                    i++;

                    result = i * ipt;
                    doWhileLabel.Text += "" + Convert.ToString(ipt) + " x " + Convert.ToString(i) + " = " + Convert.ToString(result) + "\n";

                } while (i < 10);
            }
        }
    }
}
