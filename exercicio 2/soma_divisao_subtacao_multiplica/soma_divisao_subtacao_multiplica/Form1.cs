using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soma_divisao_subtacao_multiplica
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
            calcular();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        public void calcular()
        {
            int num1;
            int num2;

            if (Int32.TryParse(textBox1.Text, out num1) && Int32.TryParse(textBox2.Text, out num2))
            {
                label8.Text = Convert.ToString(num1 + num2);
                label9.Text = Convert.ToString(num1 - num2);
                label10.Text = Convert.ToString(num1 * num2);
                if (num2 != 0)
                {
                    label11.Text = Convert.ToString(num1 / num2);
                } else
                {
                    label11.Text = "divisão por zero";
                }
            }
        }
    }
}
