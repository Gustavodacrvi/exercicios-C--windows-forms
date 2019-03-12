using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calcular()
        {
            double valor1, valor2, imc;
            if (Double.TryParse(peso.Text, out valor1) && Double.TryParse(altura.Text, out valor2))
            {
                imc = (valor2 * valor2) / valor1;
                IMC.Text = Convert.ToString(imc);
                if (imc < 18.5)
                {
                    resultado.Text = "MAGRO";
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    resultado.Text = "NORMAL";
                }
                else if (imc >= 25 && imc < 30)
                {
                    resultado.Text = "OBESO";
                }
                else
                {
                    resultado.Text = "OBESO MORBIDO";
                }
            }
        }

        private void altura_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void peso_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
