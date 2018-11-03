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
    public partial class Alta_producto : Form
    {
        Producto p;
        string marca = "";
        public Alta_producto(string codigo="",string marca="")
        {
            InitializeComponent();
            textBox1.Text = codigo;
            this.marca = marca;

        }

        private void Alta_producto_Load(object sender, EventArgs e)
        {

              p = new Producto(marca, textBox1.Text);
                if (p.validar_Existe() == -1)
                //validar que no exista ya el producto ?
                {
                    if (p.get_codigoM() == "")
                    {
                        //saber que marcas existen y cargarlas en el combobox.
                        DataTable t = Marca.Todas_Marcas();
                        for (int i = 0; i < t.Rows.Count; i++)
                        {
                            if (marca == t.Rows[i][0].ToString())
                            {
                                comboBox1.Items.Clear();
                                comboBox1.Items.Add(t.Rows[i][1].ToString());// intentar asociar con el codigo x defecto a la marca.
                                comboBox1.SelectedIndex = comboBox1.Items.Count-1;
                                // tipo.Items.Add(p.tipo_string());

                                i = t.Rows.Count;
                            }
                            else { comboBox1.Items.Add(t.Rows[i][1].ToString()); }

                        }
                        tipo.Items.Add("Perfumes");
                        tipo.Items.Add("Colores");
                        tipo.SelectedIndex = 0;

                    }
                    else
                    {

                        if (p.get_CodigoP() != "")
                        {
                            comboBox1.Items.Add(Marca.Nombre_Marca(p.get_codigoM()));
                            comboBox1.SelectedIndex = 0;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Ya existe ese codigo de producto en esta marca.");
                    this.Close();
                }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.set_CodigoP(textBox1.Text);
            bool guardar = true;
            string error = "No se pudo guardar el producto por los siguientes errores:";

            if (comboBox1.SelectedIndex ==-1) { guardar = false;
                error += "\n * Debe seleccionar una marca existente.";
            }
            else {
  p.set_codigoM(Marca.Codigo_Marca(comboBox1.Items[comboBox1.SelectedIndex].ToString()));
  // MessageBox.Show(Marca.Codigo_Marca(comboBox1.Items[comboBox1.SelectedIndex].ToString()));

            }
            if (tipo.SelectedIndex ==-1) { guardar = false;
               error+="\n * Debe seleccionar un tipo existente."; }
                else {
                if (tipo.Items[tipo.SelectedIndex].ToString() == "Perfumes") { p.set_CodigoT("Perfumes"); }
                else { p.set_CodigoT("Colores"); }
                }

            if (p.set_NombreP(textBox3.Text) == 0|| textBox3.Text==string.Empty) { guardar = false;
                error += "\n * El nombre solo puede tener 300 caracteres y no puede estar vacio.";
            }
            if (p.set_DetalleP(textBox4.Text) == 0||textBox4.Text==string.Empty) { guardar = false;
                error += "\n * El Detalle solo puede tener 300 caracteres y no puede estar vacio.";
            }
            try
            {
                if (p.set_Stock(int.Parse(stock.Text)) == 0)
                {
                    guardar = false;
                    error += "\n * El stock debe ser mayor o igual a 1.";
                }
            }
            catch (Exception)
            {
                error += "\n * El stock debe ser mayor o igual a 1.";
            }
           
            if (p.set_precio(precio.Text) == 0) { guardar = false;
                error += "\n * El Precio debe ser mayor o igual a 1.";
            }

            if (guardar == true)
            {

                if (p.alta_registro() == 1)
                {
                    MessageBox.Show("Producto Guardado exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error ALTA_P1");
                    Application.Exit();
                }
            }
            else {
                MessageBox.Show(error);
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
                else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            
           


        }

        private void precio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
