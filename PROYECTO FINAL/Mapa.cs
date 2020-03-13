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
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
            StringBuilder c_direcc = new StringBuilder();
            c_direcc.Append("https://maps.google.com/maps?q=");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(c_direcc.ToString());
        }

        private void Mapa_Load(object sender, EventArgs e)
        {


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StringBuilder c_direcc = new StringBuilder();
            c_direcc.Append("https://maps.google.com/maps?q=");
            if (textBox1.Text != string.Empty)
            {
                c_direcc.Append(textBox1.Text + "," + "+");
            }
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(c_direcc.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StringBuilder c_direcc = new StringBuilder();
            c_direcc.Append("https://maps.google.com/maps?q=");
            if (textBox2.Text != string.Empty)
            {
                c_direcc.Append(textBox2.Text + "," + "+");
            }
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate(c_direcc.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Productos productos1 = new Productos();
            productos1.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
            textBox2.Enabled = true;
            textBox2.Text = ("");

            if (checkBox1.Checked)
            {
                textBox2.Enabled = false;
                textBox2.Text = textBox1.Text;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TipoDeServicio obj = new TipoDeServicio();
            obj.Show();
            this.Hide();
        }
    }
}
