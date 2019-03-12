using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacoes_matematicas
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void somar_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            if (Int32.TryParse(textBox1.Text, out valor1) && Int32.TryParse(textBox2.Text, out valor2))
            {
                resultado.Text = Convert.ToString(valor1 + valor2);
            }
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            if (Int32.TryParse(textBox1.Text, out valor1) && Int32.TryParse(textBox2.Text, out valor2))
            {
                resultado.Text = Convert.ToString(valor1 - valor2);
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            if (Int32.TryParse(textBox1.Text, out valor1) && Int32.TryParse(textBox2.Text, out valor2))
            {
                resultado.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            int valor1, valor2;
            if (Int32.TryParse(textBox1.Text, out valor1) && Int32.TryParse(textBox2.Text, out valor2))
            {
                if (valor2 != 0)
                {
                    resultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }
    }
}
