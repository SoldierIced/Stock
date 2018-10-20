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
        private int CodigoT=0 ; //-- 1 perfumes , 2-- colores
        private string DetalleP= "";//-- cosa especifica del prodcuto: "250g, 6 unidades." o "200 mililitros.
        private int stock = 0;
        private float precio = 0;

        public string get_codigoM() { return CodigoM; }
        public string get_CodigoP() { return CodigoP; }
        public string get_NombreP() { return NombreP; }
        public string get_DetalleP() { return DetalleP; }
        public int get_stock() { return stock; }
        public int get_CodigoT() { return CodigoT; }
        public float get_precio() { return precio; }

        public void set_codigoM(string val) { CodigoM = val; }
        public void set_CodigoP(string val) { CodigoP = val; }
        public void set_CodigoT(int val) { CodigoT = val; }
        public int set_NombreP(string val) { if (val.Length <= 300) { NombreP = val; return 1; }return 0; }
        public int set_DetalleP(string val) { if (val.Length <= 300) { DetalleP = val;return 1; }return 0; }
        public int set_Stock(int val) { if (val >= 1) { stock = val;return 1; }return 0; }
        public int set_precio(float val) { if (val >= 1) { precio = val;return 1; }return 0; }
       
        public Producto() { }
        public  Producto(string marcaC, string productoC) {
            string consulta = "select * from ProductosxMarca where CodigoM='"+marcaC+"' and CodigoP='"+productoC+"'";
            AccesoDatos aq = new AccesoDatos();
            DataTable t = aq.ObtenerTabla("Productos", consulta);
            try
            {
                if (t.Rows.Count != 0)
                {
                    string CodigoM = t.Rows[0][0].ToString();
                    string CodigoP = t.Rows[0][1].ToString();
                    if (t.Rows[0][2].ToString() != "")
                    {
                         CodigoT = int.Parse(t.Rows[0][2].ToString());
                    }

                    string NombreP = t.Rows[0][3].ToString();
                    string DetalleP = t.Rows[0][4].ToString();
                    if (t.Rows[0][5].ToString() != "")
                    {  stock = int.Parse(t.Rows[0][5].ToString()); }
                    if (t.Rows[0][6].ToString() != "")
                    { precio  = float.Parse(t.Rows[0][6].ToString()); }
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

        public int validar_Existe() {
            
            string consulta = "select * from ProductosxMarca";
            AccesoDatos aq = new AccesoDatos();
            try {
                DataTable t = aq.ObtenerTabla("Productos", consulta);

                for (int i = 0; i < t.Rows.Count; i++) { 
                    if (t.Rows[0][0].ToString() == CodigoM && t.Rows[0][0].ToString()==CodigoP)
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

        public string tipo_string() {

            switch (CodigoT) {

                case 1:
                    return "Perfumes";
                    break;
                case 2:
                    return "Colores";
                    break;
                default:
                    return "";
                    break;

            }
            

            
        }
    }
}
