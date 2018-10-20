using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASAI
{
    public partial class Escanear : Form
    {
        public string codigo="";
        public string codigo_MARCA="";
        public Escanear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") { 

            this.DialogResult = DialogResult.OK;
            codigo = textBox1.Text;
            codigo_MARCA = textBox2.Text;
            this.Close();
            }
            else { MessageBox.Show("Ingrese algun valor en los campos."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = "";
            codigo_MARCA = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
