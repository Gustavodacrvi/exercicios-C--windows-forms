using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter_medidas_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            int inteiro;
            if (Int32.TryParse(input.Text, out inteiro))
                result.Text = Convert.ToString(ParaFahrenheit(inteiro));
        }

        public int ParaFahrenheit(int celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
