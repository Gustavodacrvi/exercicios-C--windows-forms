using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trocar_valores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            trocar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            trocar();
        }

        public void trocar()
        {
            vala.Text = textBox2.Text;
            valb.Text = textBox1.Text;
        }
    }
}
