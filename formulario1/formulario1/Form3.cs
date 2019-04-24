using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2,n3, resultado;
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);
            n3 = n2 / 100;
            resultado = n1 * n3;
            textBox3.Text = resultado.ToString();

            if (radioButton1.Checked==true)
            {
                textBox4.Text = (resultado+n1).ToString();
            }
            else if(radioButton2.Checked==true){
                textBox4.Text = resultado.ToString();
            }
        }
    }
}
