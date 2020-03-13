using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PROYECTO_FINAL
{
    public partial class Iniciosesion : Form
    {
        public Iniciosesion()
        {
            InitializeComponent();
        }

        private void Iniciosesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("Server=localhost;database=lavanderia;uid=root;pwd=;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("select *from usuarios where Nombre = '" + textBox1.Text + "'and Contraseña = '" + textBox2.Text + "' ");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                TipoDeServicio objeto = new TipoDeServicio();
                objeto.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña INCORRECTA");
            }
            conectar.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Registro objeto = new Registro();
            objeto.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Inicioregistro objeto = new Inicioregistro();
            objeto.Show();
            this.Hide();
        }
    }
}
