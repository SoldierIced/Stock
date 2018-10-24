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
    public partial class Modificar_Producto : Form
    {
        Producto p;
        public Modificar_Producto(string codigop, string codigom)
        {
            InitializeComponent();
            p = new Producto(codigom, codigop);
        }

        void cargartext() {
            Marcat.Text = Marca.Nombre_Marca(p.get_codigoM());
            Codigo.Text = p.get_CodigoP();
            Nombre.Text = p.get_NombreP();
            tipo.Text = p.get_CodigoT();
            Detalle.Text = p.get_DetalleP();
            stock.Text = p.get_stock().ToString();
            precio.Text = p.get_precio();
        }
        private void Modificar_Producto_Load(object sender, EventArgs e)
        {
            cargartext();
            tipo.Items.Add("Perfumes");
            tipo.Items.Add("Colores");
            for (int i = 0; i < tipo.Items.Count; i++)
                if (tipo.Items[i].ToString() == p.get_CodigoT()) { tipo.SelectedIndex = i; }

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

        private void stock_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            bool guardar = true;
            string error = "No se pudo guardar el producto por los siguientes errores:";

           
         
            if (tipo.SelectedIndex == -1)
            {
                guardar = false;
                error += "\n * Debe seleccionar un tipo.";
            }
            else
            {
                if (tipo.Items[tipo.SelectedIndex].ToString() == "Perfumes") { p.set_CodigoT("Perfumes"); }
                else { p.set_CodigoT("Colores"); }
            }

            if (p.set_NombreP(Nombre.Text) == 0)
            {
                guardar = false;
                error += "\n * El nombre solo puede tener 300 caracteres.";
            }
            if (p.set_DetalleP(Detalle.Text) == 0)
            {
                guardar = false;
                error += "\n * El Detalle solo puede tener 300 caracteres.";
            }
            if (p.set_Stock(int.Parse(stock.Text)) == 0)
            {
                guardar = false;
                error += "\n * El stock debe ser mayor o igual a 1.";
            }
            if (p.set_precio(precio.Text) == 0)
            {
                guardar = false;
                error += "\n * El Precio debe ser mayor o igual a 1.";
            }

            if (guardar == true)
            {

                if (p.update_producto() == 1)
                {
                    MessageBox.Show("Producto actualizado exitosamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error MOD_P 1");
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show(error);
            }

        }
    }
}
