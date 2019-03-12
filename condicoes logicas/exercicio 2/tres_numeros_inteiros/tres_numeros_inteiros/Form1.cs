using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tres_numeros_inteiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        public void calcular()
        {
            int[] valores = Enumerable.Range(0, 3).ToArray();
            if (Int32.TryParse(textBox1.Text, out valores[0]) && Int32.TryParse(textBox2.Text, out valores[1]) && Int32.TryParse(textBox3.Text, out valores[2]))
            {
                int maior = valores[0];
                for (int i =1;i<valores.Length;i++)
                {
                    if (valores[i] > maior)
                    {
                        maior = valores[i];
                    }
                }
                resultado.Text = Convert.ToString(maior);
            }
        }
    }
}
