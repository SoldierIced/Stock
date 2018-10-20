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
    public partial class Listar_Productos : Form
    {
        AccesoDatos aq = new AccesoDatos();
        public Listar_Productos()
        {
            InitializeComponent();
        }

        void cargargrid(string consulta) {
          gv.DataSource=  aq.ObtenerTabla("grid", consulta);
                }

        void cargarcombos() {
        DataTable t=    Marca.Todas_Marcas();
            for (int i = 0; i < t.Rows.Count; i++) { 
           marca.Items.Add( t.Rows[i][1].ToString());
            }
            
            Tipo.Items.Add("Perfumes");
            Tipo.Items.Add("Colores");
                    }

        private void Listar_Productos_Load(object sender, EventArgs e)
        {
            cargargrid("select CodigoM as [Marca],CodigoT as [Tipo],NombreP as [Nombre del Producto],DetalleP as [Detalle del Producto],Stock,Precio, CodigoP as [Codigo Producto] from ProductosxMarca");
            cargarcombos();
        }

        private void Listar_Productos_Resize(object sender, EventArgs e)
        {
           gv.Height= this.Height -groupBox1.Height-100;
            gv.Width = this.Width - 20;
            groupBox1.Width = this.Width-70;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
