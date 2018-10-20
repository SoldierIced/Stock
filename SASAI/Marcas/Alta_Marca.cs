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
    public partial class Alta_Materia : Form
    {
        Marca ma = new Marca();
        public Alta_Materia(string codigo="")
        {
            InitializeComponent();
            if (codigo != "")
                textBox1.Text = codigo;

        }

        private void Alta_Materia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ma.codigoM = textBox1.Text;
            ma.nombreM = textBox2.Text;
            if (ma.set_detalle(textBox3.Text) == true)
            {
                ma.DetalleM = textBox3.Text;
                if (ma.registro_Existente() == false)
                {
                    if (ma.registro_Alta() == true)
                    {
                        MessageBox.Show("Marca dada de alta.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("error M1");
                        Application.Exit();
                    }
                }
                else {

                    MessageBox.Show("Esa Marca ya esta dada de alta.");
                    this.Close();
                }

            }
            else {
                MessageBox.Show("No se puede ingresar mas de 300 caracteres.");
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
