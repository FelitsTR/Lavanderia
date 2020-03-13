using MySql.Data.MySqlClient;
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
    public partial class Iniciosesion : Form
    {
        public Iniciosesion()
        {
            InitializeComponent();
        }

        private void Iniciosesion_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            mostrar();
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
        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
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
        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void buscar()
        {
            //BUSCAR REGISTRO POR CODIGO
            int contar_filas;
            Conexionsql buscar = new Conexionsql();
            buscar.crearconexion();
            string search = "select * from usuarios where usuario='" + textBox1.Text + "' and contraseña='"+ textBox2.Text +"';";
            MySqlCommand busca = new MySqlCommand(search, buscar.getConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(busca);
            DataSet tht = new DataSet();
            busca.Connection = buscar.getConexion();
            cmc.Fill(tht, "usuarios");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = tht.Tables["usuarios"].DefaultView;
            contar_filas = dataGridView1.RowCount;
            if (contar_filas > 1)
            {
                MessageBox.Show("Busqueda Exitosa", "Buscando en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar.cerrarconexion();
                Mapa objeto = new Mapa();
                objeto.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Existe el registro solicitado", "Buscando en la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                limpiar();
            }
        }
    }
}
