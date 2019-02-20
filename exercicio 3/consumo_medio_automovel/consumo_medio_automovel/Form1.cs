using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumo_medio_automovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            int num1;
            int num2;

            if (Int32.TryParse(textBox1.Text, out num1) && Int32.TryParse(textBox2.Text, out num2))
            {
                label5.Text = Convert.ToString(num1 / num2);
                label5.Text += " metros/litro";
            }
        }
    }
}
