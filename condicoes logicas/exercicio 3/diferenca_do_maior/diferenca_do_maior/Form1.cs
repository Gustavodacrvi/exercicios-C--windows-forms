using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diferenca_do_maior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calcular()
        {
            int valor1, valor2;
            if (Int32.TryParse(input1.Text, out valor1) && Int32.TryParse(input2.Text, out valor2))
            {
                if (valor1 > valor2)
                {
                    resultado.Text = Convert.ToString(valor1 - valor2);
                } else
                {
                    resultado.Text = Convert.ToString(valor2 - valor1);
                }
            }
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void input2_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
