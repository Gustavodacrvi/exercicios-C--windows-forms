using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendedor_salario
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            name.Text = textBox1.Text;
            decimal sfixo;

            if (Decimal.TryParse(textBox2.Text, out sfixo))
            {
                fixo.Text = String.Format("{0:C}", sfixo);
            }

            decimal money;

            if (Decimal.TryParse(textBox2.Text, out sfixo) && Decimal.TryParse(textBox3.Text, out money))
            {
                decimal result = money * 1.15m + sfixo;
                final.Text = result.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
