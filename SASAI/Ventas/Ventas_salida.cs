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
    public partial class Ventas_salida : Form
    {
        Ventas v = new Ventas();
        Producto p;
        public Ventas_salida(string codigoM,string codigoP)
        {
            InitializeComponent();
            
            v.codigoM = codigoM;
            v.codigoP = codigoP;
            p = new Producto(v.codigoM, v.codigoP);
            //   v.codigoT = tipo;
        }

        private void Ventas_salida_Load(object sender, EventArgs e)
        {
            
            marcat.Text = Marca.Nombre_Marca(p.get_codigoM());
            nombret.Text = p.get_NombreP();
            detallet.Text = p.get_DetalleP();
            v.codigoT = p.get_CodigoT();
            v.precio =float.Parse( p.get_precio());
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidadt.Text= cantidadt.Text.Replace(",", ".");
           v.cantidad=int.Parse( cantidadt.Text);
            if (v.cantidad >= 1)
            {
                if (p.descontarstock(v.cantidad) != 0)
                {
                    this.DialogResult = DialogResult.OK;
                    if (p.get_stock() - v.cantidad <= 3)
                    {
                        v.insert_venta();
                        MessageBox.Show("Stock descontado, \n Stock Disponible: " + (p.get_stock() - v.cantidad));

                    }
                    else {
                        v.insert_venta();
                        MessageBox.Show("Stock descontado");

                    }

                 this.Close();
                }
                else {
                    MessageBox.Show("No hay stock suficiente \n  Stock disponible:" + p.get_stock());
                }

            }

            else {
                MessageBox.Show("La cantidad a vender debe ser mayor o igual a 1");
            }

            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
