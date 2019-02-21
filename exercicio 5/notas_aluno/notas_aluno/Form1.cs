using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas_aluno
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

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            nome.Text = textBox1.Text;

            int num1;
            int num2;
            int num3;

            if (Int32.TryParse(textBox2.Text, out num1) && Int32.TryParse(textBox3.Text, out num2) && Int32.TryParse(textBox4.Text, out num3))
            {
                media.Text = Convert.ToString((num1 + num2 + num3) / 3);
            }
        }
    }
}
