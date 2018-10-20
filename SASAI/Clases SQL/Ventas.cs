using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASAI
{
    class Ventas
    {
        
    //  public  string codigoV = "";
        public string codigoM = "";
        public string codigoP = "";
        public string codigoT = "";
        public int cantidad = 0;
        public float precio = 0;
        public string fecha = DateTime.Today.ToShortDateString();

        public int insert_venta() {
            string p = "";
             p = precio.ToString().Replace(",", ".");
            precio = float.Parse(p);
            string consulta = "insert into ventas(codigom, codigop, codigot, cantidad,precio) select '"+codigoM+"','"+codigoP+"','"+codigoT+"',"+cantidad+","+p;
            AccesoDatos aq = new AccesoDatos();
            MessageBox.Show(consulta);
            try
            {

                aq.aplicarconsultasql(consulta);
                return 1;
            }
            catch (Exception)
            {

                return 0;                
            }


        }

    }
}
