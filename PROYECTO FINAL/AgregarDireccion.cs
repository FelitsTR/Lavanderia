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
    public partial class AgregarDireccion : Form
    {
        public AgregarDireccion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TipoDeServicio obj = new TipoDeServicio();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MySqlConnection conectar = new MySqlConnection("Server=localhost;database=lavanderia;uid=root;pwd=;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;

          
            string actualizar = " UPDATE usuarios SET Telefono=@c1, "+"Dirección=@c2"+ " where Contraseña='" + textBox3.Text +"';";
            MySqlCommand revisa = new MySqlCommand(actualizar);
            revisa.Connection = conectar;
            revisa.Parameters.AddWithValue("@c1", (textBox2.Text));
            revisa.Parameters.AddWithValue("@c2", (textBox1.Text));
            MessageBox.Show("PERFECTO");
            revisa.ExecuteNonQuery();
            conectar.Close();

            Mapa objec = new Mapa();
            objec.Show();
            this.Hide();


        }
    }
}
