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
    public partial class Ventas_Listar : Form
    {
        public Ventas_Listar()
        {
            InitializeComponent();
        }

        void cargargrid(string consulta= "select top(50) CodigoM as [Marca], CodigoP as [Producto], CodigoT as Tipo, Cantidad,Precio as [Precio x Uni.],Fecha from ventas") {
           
            AccesoDatos aq = new AccesoDatos();
            DataTable t = aq.ObtenerTabla("ventas", consulta);
            for (int i = 0; i < t.Columns.Count; i++)
            {
                if (i == 2)
                    gv.Columns.Add("Detalle Producto", "Detalle Producto");

                gv.Columns.Add(t.Columns[i].ColumnName, t.Columns[i].ColumnName);
             }

            for (int i = 0; i < t.Rows.Count; i++) {
                gv.Rows.Add();
                Producto p = new Producto(t.Rows[i][0].ToString(), t.Rows[i][1].ToString());
                gv.Rows[i].Cells[0].Value = Marca.Nombre_Marca(t.Rows[i][0].ToString());
                gv.Rows[i].Cells[1].Value = p.get_NombreP();
                gv.Rows[i].Cells[2].Value = p.get_DetalleP();
                gv.Rows[i].Cells[3].Value = t.Rows[i][2].ToString();
                gv.Rows[i].Cells[4].Value = t.Rows[i][3].ToString();
                gv.Rows[i].Cells[5].Value = t.Rows[i][4].ToString();
                gv.Rows[i].Cells[6].Value = t.Rows[i][5].ToString();

            }
            gv.ReadOnly = true;
        }

        private void Ventas_Listar_Load(object sender, EventArgs e)
        {
            cargargrid();

        
        }
    }
}
