using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SASAI
{
    class Producto
    {
        
        private string CodigoM = "";
        private string CodigoP = "";
        private string NombreP= "";//nombre producto: GALLETITAS DE CHOCOLATE o "perfume sabor chocolate"
        private string CodigoT="" ; //-- 1 perfumes , 2-- colores
        private string DetalleP= "";//-- cosa especifica del prodcuto: "250g, 6 unidades." o "200 mililitros.
        private int stock = 0;
        private string precio = "";

        public string get_codigoM() { return CodigoM; }
        public string get_CodigoP() { return CodigoP; }
        public string get_NombreP() { return NombreP; }
        public string get_DetalleP() { return DetalleP; }
        public int get_stock() { return stock; }
        public string get_CodigoT() { return CodigoT; }
        public string get_precio() { return precio; }

        public void set_codigoM(string val) { CodigoM = val; }
        public void set_CodigoP(string val) { CodigoP = val; }
        public void set_CodigoT(string val) { CodigoT = val; }
        public int set_NombreP(string val) { if (val.Length <= 300) { NombreP = val; return 1; }return 0; }
        public int set_DetalleP(string val) { if (val.Length <= 300) { DetalleP = val;return 1; }return 0; }
        public int set_Stock(int val) { if (val >= 1) { stock = val;return 1; }return 0; }
        public int set_precio(string val) { try { if (float.Parse(val) >= 1) { precio = val; return 1; } return 0; } catch (Exception) { return 0; } }
       
        public Producto() { }
        public  Producto(string marcaC, string productoC) {
            string consulta = "select * from ProductosxMarca where CodigoM='"+marcaC+"' and CodigoP='"+productoC+"'";
            AccesoDatos aq = new AccesoDatos();
            DataTable t = aq.ObtenerTabla("Productos", consulta);
            try
            {
                if (t.Rows.Count != 0)
                {
                     CodigoM = t.Rows[0][0].ToString();
                     CodigoP = t.Rows[0][1].ToString();
                    
                         CodigoT =t.Rows[0][2].ToString();
                    

                     NombreP = t.Rows[0][3].ToString();
                     DetalleP = t.Rows[0][4].ToString();
                    if (t.Rows[0][5].ToString() != "")
                    {  stock = int.Parse(t.Rows[0][5].ToString()); }
                    if (t.Rows[0][6].ToString() != "")
                    { precio  = t.Rows[0][6].ToString(); }
                }
                else {
                  
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Error P2");
                //Application.Exit();
                
                MessageBox.Show(ex.ToString());

            }

        }

        public int descontarstock(int val) {
            string consulta = "";

            if (stock - val >= 0)
                {
                int sto = stock - val;
                consulta = "update ProductosxMarca set stock=" + sto + " where CodigoM='" + CodigoM + "' and CodigoP='" + CodigoP + "' ";
                AccesoDatos aq = new AccesoDatos();
                try
                {
                    aq.aplicarconsultasql(consulta);
                    return 1;
                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR Prod.Venta 1");
                    Application.Exit();
                    return 0;
                }
             

            }
            else { return 0; }


         
        }
        public int validar_Existe() {
            
            string consulta = "select * from ProductosxMarca";
            AccesoDatos aq = new AccesoDatos();
            try {
                DataTable t = aq.ObtenerTabla("Productos", consulta);

                for (int i = 0; i < t.Rows.Count; i++) { 
                    if (t.Rows[i][0].ToString() == CodigoM && t.Rows[i][1].ToString()==CodigoP)
                    {
                        return i;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error P1");
                Application.Exit();
            }
            return -1;
        }

        static DataTable  todos_Productos() {
            string consulta = "select * from ProductosxMarca";
            AccesoDatos aq = new AccesoDatos();
       return     aq.ObtenerTabla("Productos", consulta);
            }

        public int alta_registro() {

            AccesoDatos aq = new AccesoDatos();
            try
            {
                aq.aplicarconsultasql("insert into ProductosxMarca select " +
              "'" + CodigoM + "','" + CodigoP + "','" + CodigoT + "','" + NombreP + "','" + DetalleP + "'," + stock+","+precio);
                return 1;
            }
            catch (Exception ex) {

                return -1;
                }
            }
        public int update_producto() {

            string pre = precio.Replace(",", ".");
            string consulta = "update ProductosxMarca  set CodigoT = '"+CodigoT+"', NombreP = '"+NombreP+"', DetalleP =" +
                " '"+DetalleP+"', stock ="+stock+", precio ="+pre+" where CodigoM = '"+CodigoM+"' and CodigoP = '"+CodigoP+"'";
            
            AccesoDatos aq = new AccesoDatos();
            try
            {
                aq.aplicarconsultasql(consulta);
                return 1;
            }
            catch (Exception) {
                return 0;
            }
        }
        public static DataTable Todos_productos(string consulta= "select * from ProductosxMarca")
        {
            
            AccesoDatos aq = new AccesoDatos();
            return aq.ObtenerTabla("productos", consulta);
        }

    }
}
