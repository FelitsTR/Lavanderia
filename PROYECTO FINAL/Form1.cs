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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicioregistro ventana2 = new Inicioregistro();
            ventana2.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
