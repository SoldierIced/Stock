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
        int inicial = 0;
        string vcons = "";
        AccesoDatos aq = new AccesoDatos();
        public Listar_Productos()
        {
            InitializeComponent();
        }

        void cargargrid(string consulta)
        {
            DataTable t = new DataTable();
            gv.DataSource = null;
            gv.Columns.Clear();
            gv.Rows.Clear();
            t= aq.ObtenerTabla("grid", consulta);
            for (int i = 0; i < t.Columns.Count; i++) {
                gv.Columns.Add(t.Columns[i].ColumnName, t.Columns[i].ColumnName);
            }
            for (int i = 0; i < t.Rows.Count; i++)
            {
                gv.Rows.Add();
                gv.Rows[i].Cells["Marca"].Value = t.Rows[i]["Marca"].ToString() ;
                gv.Rows[i].Cells["Tipo"].Value = t.Rows[i]["Tipo"].ToString();
                gv.Rows[i].Cells["Nombre del Producto"].Value = t.Rows[i]["Nombre del Producto"].ToString();
                gv.Rows[i].Cells["Detalle del Producto"].Value = t.Rows[i]["Detalle del Producto"].ToString();
                gv.Rows[i].Cells["Stock"].Value = t.Rows[i]["Stock"].ToString();
                gv.Rows[i].Cells["Precio"].Value = t.Rows[i]["Precio"].ToString();
                gv.Rows[i].Cells["Codigo Producto"].Value = t.Rows[i]["Codigo Producto"].ToString();
            }
               for (int i = 0; i < gv.Columns.Count; i++)
                   gv.Columns[i].ReadOnly = true;


               gv.Columns["Codigo Producto"].Visible = false;
               gv.Columns["Stock"].ReadOnly = false;
               gv.Columns["Precio"].ReadOnly = false;

            inicial = 1;
        }

        void cargardetalle()
        {
            DataTable p = Producto.Todos_productos();
            for (int i = 0; i < p.Rows.Count; i++)
            {
                detalle.Items.Add(p.Rows[i]["DetalleP"].ToString());
            }

        }
        void cargarcombos()
        {
            DataTable t = Marca.Todas_Marcas();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                marca.Items.Add(t.Rows[i]["Nombre de la Marca"].ToString());
            }
            cargardetalle();

            Tipo.Items.Add("Perfumes");
            Tipo.Items.Add("Colores");
        }


        void cargaInicial(string consulta = "select Marcas.NombreM as [Marca],CodigoT as [Tipo],NombreP as [Nombre del Producto],DetalleP as [Detalle del Producto],Stock,Precio, CodigoP as [Codigo Producto] from" +
                 " ProductosxMarca inner join Marcas on Marcas.CodigoM = ProductosxMarca.CodigoM") {
           
            cargargrid(consulta);
            cargarcombos();

            inicial = 1;
        }
        private void Listar_Productos_Load(object sender, EventArgs e)
        {
            cargaInicial();
        }

        private void Listar_Productos_Resize(object sender, EventArgs e)
        {
            gv.Height = this.Height - groupBox1.Height - 100;
            gv.Width = this.Width - 20;
            groupBox1.Width = this.Width - 70;
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
            if (e.KeyChar == ',') { e.Handled = true; }
        }

        string armarconsulta()
        {

            string consulta = "select Marcas.NombreM as [Marca],CodigoT as [Tipo],NombreP as [Nombre del Producto],DetalleP as [Detalle del Producto],Stock,Precio, CodigoP as [Codigo Producto] from" +
                " ProductosxMarca inner join Marcas on Marcas.CodigoM = ProductosxMarca.CodigoM";
            int aux = 0;
            if (marca.Text != "")
            {

                consulta += " where Marcas.NombreM like  '%" + marca.Text + "%' ";
                aux++;

            }
            if (Tipo.Text != "")
            {
                if (aux != 0)
                {
                    aux++;
                    consulta += " and ";
                }
                else { consulta += " where "; aux++; }
                consulta += " CodigoT like '%" + Tipo.Text + "%' ";
                aux++;
            }
            if (NombreP.Text != "")
            {
                if (aux != 0)
                {
                    aux++;
                    consulta += " and ";
                }
                else { consulta += " where "; aux++; }
                consulta += " NombreP like '%" + NombreP.Text + "%' ";
                aux++;
            }
            if (detalle.Text != "")
            {
                if (aux != 0)
                {
                    aux++;
                    consulta += " and ";
                }
                else { consulta += " where "; aux++; }
                consulta += " detallep like '%" + detalle.Text + "%' ";
                aux++;
            }
            if (stock.Text != "")
            {
                if (aux != 0)
                {
                    aux++;
                    consulta += " and ";
                }
                else { consulta += " where "; aux++; }
                string aux2 = "";
                if (smay.Checked == true)
                {
                    aux2 = ">=";
                }
                if (smen.Checked == true)
                {
                    aux2 = "<=";
                }
                if (sigu.Checked == true)
                {
                    aux2 = "=";

                }

                consulta += " Stock " + aux2 + stock.Text + " ";
                aux++;

            }
            if (precio.Text != "")
            {
                if (aux != 0)
                {
                    aux++;
                    consulta += " and ";
                }
                else { consulta += " where "; aux++; }
                string aux2 = "";
                if (pmay.Checked == true)
                {
                    aux2 = ">=";
                }
                if (pmen.Checked == true)
                {
                    aux2 = "<=";
                }
                if (pigu.Checked == true)
                {
                    aux2 = "=";

                }

                consulta += " Precio " + aux2 + precio.Text + " ";
                aux++;

            }


            return consulta;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            inicial = 0;
          vcons=  armarconsulta();
            cargargrid(armarconsulta());

        }

        private void marca_TextUpdate(object sender, EventArgs e)
        {
            try { cargardetalle_v2(); }
            catch (Exception) { }
           

        }

        void cargardetalle_v2() {
            if (marca.Text != "")
            {
                string consulta = "select DetalleP from ProductosxMarca inner join Marcas on Marcas.CodigoM= ProductosxMarca.CodigoM where " +
                    " Marcas.NombreM like '%" + marca.Text + "%'";
                detalle.Items.Clear();
                DataTable p = Producto.Todos_productos(consulta);
                for (int i = 0; i < p.Rows.Count; i++)
                {
                    detalle.Items.Add(p.Rows[i]["DetalleP"].ToString());
                }
                detalle.Text = "";
            }
            else
            {
                detalle.Items.Clear();
                cargardetalle();
                detalle.Text = "";
            }
        }
        private void marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargardetalle_v2();
        }

        private void marca_SelectedValueChanged(object sender, EventArgs e)
        {
            cargardetalle_v2();
        }
        void borrartodo() {
            marca.Text = "";
            Tipo.Text = "";
            detalle.Text = "";
            NombreP.Text = "";
            stock.Text = "";
            precio.Text = "";
            smay.Checked = false;
            smen.Checked = false;
            sigu.Checked = false;
            pmay.Checked = false;
            pmen.Checked = false;
            pigu.Checked = false;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            inicial = 0;
            borrartodo();
            string consulta = "select Marcas.NombreM as [Marca],CodigoT as [Tipo],NombreP as [Nombre del Producto],DetalleP as [Detalle del Producto],Stock,Precio, CodigoP as [Codigo Producto] from" +
                 " ProductosxMarca inner join Marcas on Marcas.CodigoM = ProductosxMarca.CodigoM";
            cargargrid(consulta);
            
        }

        private void gv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            /*gv.Rows[i].Cells["Stock"].Value = t.Rows[i]["Stock"].ToString();
                gv.Rows[i].Cells["Precio"].Value = t.Rows[i]["Precio"].ToString();*/
            
            if (inicial!=0) {
                int row = e.RowIndex;
                int cel = e.ColumnIndex;
                string codigo = Marca.Codigo_Marca(gv.Rows[row].Cells["Marca"].Value.ToString());
            Producto p = new Producto(codigo, gv.Rows[row].Cells["Codigo Producto"].Value.ToString());
            try
            {

                    if (gv.Columns[cel].HeaderText == "Stock")
                    {
                        try
                        {
                            int sto = int.Parse(gv.Rows[row].Cells[cel].Value.ToString());
                            p.set_Stock(sto);
                            if (p.update_producto() == 1)
                            {

                            }
                            else
                            {
                                MessageBox.Show("ERROR LIST_PRO 1");
                                Application.Exit();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Recuerde que el stock tiene que ser un numero entero.");
                            inicial = 0;
                            cargaInicial(vcons);

                        }
                    }
                    else if(gv.Columns[cel].HeaderText == "Precio") {
                        try
                        {
                            gv.Rows[row].Cells[cel].Value = gv.Rows[row].Cells[cel].Value.ToString().Replace(",", ".");
                          //  MessageBox.Show(gv.Rows[row].Cells[cel].Value.ToString());
                           float.Parse(gv.Rows[row].Cells[cel].Value.ToString()).ToString();

                            string pre = gv.Rows[row].Cells[cel].Value.ToString();
                       //     MessageBox.Show(pre);
                            p.set_precio(pre);
                            if (p.update_producto() == 1)
                            {

                            }
                            else
                            {
                                MessageBox.Show("ERROR LIST_PRO 2");
                                Application.Exit();
                            }
                        }
                        catch (Exception) {
                            MessageBox.Show("Recuerde que el Precio tiene que ser un numero, puede contener coma o punto .");
                            inicial = 0;
                            cargaInicial(vcons);
                        }

                    }
               
                

            } catch (Exception) { }
        }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
