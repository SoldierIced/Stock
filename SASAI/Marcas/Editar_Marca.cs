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
    public partial class Editar_Marca : Form
    {
        Marca m = new Marca();
        string codigo = "";
        public Editar_Marca(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.nombreM = textBox2.Text;
            m.DetalleM = textBox3.Text;

            if (m.registro_update() == true)
            {

                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Marca Editada correctamente.");
                this.Close();
            }
            else {
                MessageBox.Show("Error N2 Marca.");
                Application.Exit();
            }
        }

        private void Editar_Marca_Load(object sender, EventArgs e)
        {
          
            try {
              m=  Marca.cargar_registro(codigo);
            } catch (Exception ex) { MessageBox.Show("ERROR EDITAR_MARCA 1"); Application.Exit(); }

            if (m.codigoM != "")
            {
                textBox1.Text = m.codigoM;
                textBox2.Text = m.nombreM;
                textBox3.Text = m.DetalleM;
            }
            else {
                //   MessageBox.Show("");
                Validacion v = new Validacion("el codigo de barra no existe. Desea crear esta marca?");
                if (v.ShowDialog() == DialogResult.OK)
                {
                    Formularios.AbrirFormularioHijos(new Alta_Materia());
                }
                else { this.Close(); }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
