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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String u, c;
            u = textBox1.Text.TrimEnd();
            c = textBox2.Text.TrimEnd();
            if ((u == "utec") && (c == "programacion1"))
            {


                MessageBox.Show("BIENVENIDO AL SISTEMA");
                
                MDIParent1 hijo = new MDIParent1();
                hijo.Show(); 
            }
            else
            {
                MessageBox.Show("verifique usuario y contra");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
