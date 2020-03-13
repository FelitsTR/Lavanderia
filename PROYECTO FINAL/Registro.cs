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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("El correo debe coincidir","Error de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox5.Text != textBox4.Text)
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Conexionsql ingresar = new Conexionsql();
                ingresar.crearconexion();
                string insert = "INSERT INTO usuarios (usuario,contraseña,correo) values(" + "'" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "')";
                MySqlCommand pro = new MySqlCommand(insert);
                pro.Connection = ingresar.getConexion();
                pro.ExecuteNonQuery();
                ingresar.cerrarconexion();
                MessageBox.Show("Se ha agregado satisfactoriamente", "Inserción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenar();

                Iniciosesion objeto = new Iniciosesion();
                objeto.Show();
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void mostrar()
        {
            Conexionsql conecta = new Conexionsql();
            conecta.crearconexion();
            string selecciona = "select * from usuarios";
            MySqlCommand buscaproductos = new MySqlCommand(selecciona, conecta.getConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.getConexion();
            cmc.Fill(tht, "usuarios");
            dataGridView1.DataSource = tht.Tables["usuarios"].DefaultView;
        }
        public void llenar()
        {
            Conexionsql search = new Conexionsql();
            search.crearconexion();
            string search3 = "select * from usuarios";
            MySqlCommand buscaproductos = new MySqlCommand(search3, search.getConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            cmc.Fill(tht, "usuarios");
            dataGridView1.DataSource = tht.Tables["usuarios"].DefaultView;
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            mostrar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Inicioregistro objeto = new Inicioregistro();
            objeto.Show();
            this.Hide();
        }
    }
}
