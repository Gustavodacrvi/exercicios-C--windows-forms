using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nota_media_aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            nomeLabel.Text = nome.Text;
        }

        public void calcular()
        {
            int valor1, valor2, valor3;
            if (Int32.TryParse(nota1.Text, out valor1) && Int32.TryParse(nota2.Text, out valor2) && Int32.TryParse(nota3.Text, out valor3))
            {
                int medi = (valor1 + valor2 + valor3) / 3;
                media.Text = Convert.ToString(medi);

                if (medi >= 7)
                {
                    mencao.Text = "aprovado";
                } else if (medi <= 5)
                {
                    mencao.Text = "reprovado";
                } else
                {
                    mencao.Text = "recuperação";
                }
            }
        }

        private void nota1_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void nota2_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void nota3_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
