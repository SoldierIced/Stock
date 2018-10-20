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
    class Marca
    {
        private string consulta = "";
        public string codigoM = "";
        public string nombreM = "";
        public string DetalleM = "";
        private AccesoDatos aq = new AccesoDatos();
        public SqlCommand comando = new SqlCommand();
        public bool set_detalle(string val) {

            if(val.Length<=300) { return true; }
            return false;
        }

        public void p_codigoM()
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = comando.Parameters.Add("@CodigoM", SqlDbType.VarChar, 50);
            SqlParametros.Value = codigoM;
        }
        public void p_nombreM()
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = comando.Parameters.Add("@NombreM", SqlDbType.VarChar, 100);
            SqlParametros.Value = nombreM;
        }
        public void p_detalleM()
        {
            SqlParameter SqlParametros = new SqlParameter();

            SqlParametros = comando.Parameters.Add("@DetalleM", SqlDbType.VarChar, 300);
            SqlParametros.Value = nombreM;
        }

        public bool registro_Existente() {
            consulta = "select codigoM from Marcas where codigoM='" + codigoM + "'";

            if (aq.Obtenercampo("Existe", consulta) != "") { return true; }
            else { return false; }

        }
        public bool registro_Alta() {
            try {
                consulta = "insert into Marcas select '" + codigoM + "','" + nombreM + "',"+"'"+DetalleM+"'";
                aq.aplicarconsultasql(consulta);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false; }

        }


        public bool registro_update()
        {
            try
            {
                consulta = "update Marcas set NombreM='"+nombreM+"', detalleM='"+DetalleM+"' where CodigoM='"+codigoM+"'";
                aq.aplicarconsultasql(consulta);
                return true;
            }
            catch (Exception) { return false; }

        }

        public static DataTable Todas_Marcas() {
            string consulta = "select CodigoM as [Codigo de Marca], NombreM as [Nombre de la Marca], " +
                  "detalleM as [Detalle] from marcas";
            AccesoDatos aq = new AccesoDatos();
         return aq.ObtenerTabla("MarcasT",consulta);
                   }
        public static string Nombre_Marca(string codigom) {
            string consulta = "select NombreM from Marcas where codigoM='" + codigom + "'";
            AccesoDatos aq = new AccesoDatos();
                return aq.Obtenercampo("nombreMarca", consulta);
                }
        public static string Codigo_Marca(string nombrem)
        {
            string consulta = "select codigoM from Marcas where nombreM='" + nombrem + "'";
            AccesoDatos aq = new AccesoDatos();
            return aq.Obtenercampo("codigoM", consulta);
        }
        public static Marca cargar_registro(string codigo) {
            string consulta2 = "select NombreM from marcas where codigoM='" + codigo + "'";
            Marca m = new Marca();
            DataSet t = new DataSet();
            AccesoDatos aq = new AccesoDatos();
            try
            {

                m.codigoM = codigo;
              m.nombreM=  aq.Obtenercampo("Nombre", consulta2);
                consulta2 = "select DetalleM from marcas where codigoM='" + codigo + "'";
                m.DetalleM=  aq.Obtenercampo("Detalle", consulta2);
                return m;
            } catch (Exception ex ) {

                MessageBox.Show(ex.ToString());
                return m;
            }
           
        }
    }
}
