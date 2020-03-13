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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            comboBox1.Items.Add("ACE");
            comboBox1.Items.Add("ARIEL");
            comboBox1.Items.Add("VANISH");
            comboBox2.Items.Add("DOWNY");
            comboBox2.Items.Add("SUAVITEL");
            comboBox2.Items.Add("FLOR");
            comboBox3.Items.Add("FOCA");
            comboBox3.Items.Add("CLOROX");
            comboBox3.Items.Add("BLANCA NIEVES");
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mapa mapa1 = new Mapa();
            mapa1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repartidor repartidor1 = new Repartidor();
            repartidor1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(comboBox1.SelectedIndex))
            {
                case 0:
                    label10.Text = "ACE";
                    label8.Text = textBox1.Text;
                    break;
                case 1:
                    label10.Text = "ARIEL";
                    label8.Text = textBox1.Text;
                    break;
                case 2:
                    label10.Text = "VANISH";
                    label8.Text = textBox1.Text;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(comboBox2.SelectedIndex))
            {
                case 0:
                    label12.Text = "DOWNY";
                    label8.Text = textBox1.Text;
                    break;
                case 1:
                    label12.Text = "SUAVITEL";
                    label8.Text = textBox1.Text;
                    break;
                case 2:
                    label12.Text = "FLOR";
                    label8.Text = textBox1.Text;
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(comboBox3.SelectedIndex))
            {
                case 0:
                    label14.Text = "FOCA";
                    label8.Text = textBox1.Text;
                    break;
                case 1:
                    label14.Text = "CLOROX";
                    label8.Text = textBox1.Text;
                    break;
                case 2:
                    label14.Text = "BLANCA NIEVES";
                    label8.Text = textBox1.Text;
                    break;
            }
        }
    }
}
