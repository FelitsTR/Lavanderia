using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Repartidor : Form
    {
        public Repartidor()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {          
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void Repartidor_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Productos productos1 = new Productos();
            productos1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Pago pagar = new Pago();
            pagar.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            label4.Text = ("");
            label5.Text = ("");
            checkBox2.Enabled = true;
            if (checkBox2.Checked)
            {
                label5.Text = ("Scarlett Johansson Edad: 25 Categoria: 5 estrellas");
                checkBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            label4.Text = ("");
            label5.Text = ("");
            checkBox2.Enabled = true;
            if (checkBox1.Checked)
            {
                label4.Text = ("Andres Garcia Edad: 18 Categoria: 5 estrellas");
                checkBox2.Enabled = false;
            }
        }
    }
}
