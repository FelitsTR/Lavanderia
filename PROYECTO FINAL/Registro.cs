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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mapa objeto = new Mapa();
            objeto.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Inicioregistro objeto = new Inicioregistro();
            objeto.Show();
            this.Hide();
        }
    }
}
