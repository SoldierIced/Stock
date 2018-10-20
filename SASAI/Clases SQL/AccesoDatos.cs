using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de AccesoDatos
/// </summary>
public class AccesoDatos
{
    String rutaBDLibreria =
    "Data Source=localhost\\sqlexpress;Initial Catalog=STOCK;Integrated Security=True";

    public AccesoDatos()
	{
		// TODO: Agregar aquí la lógica del constructor
	}
    public DataTable ObtenerTabla(String Nombre, String Sql)
    {
        DataSet ds = new DataSet();
        AccesoDatos datos = new AccesoDatos();
        SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
        adp.Fill(ds, Nombre);
        return ds.Tables[Nombre];
    }
    public SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
    {
        SqlDataAdapter adaptador;
        try
        {
            adaptador = new SqlDataAdapter(consultaSql, cn);
            return adaptador;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public void cargaTabla_old(String NombreTabla, String Sql, ref DataSet ds)
    {

        SqlConnection cn = ObtenerConexion();
        SqlDataAdapter adp = ObtenerAdaptador(Sql, cn);
        adp.Fill(ds, NombreTabla);
    }

    private SqlConnection ObtenerConexion()
    {
        SqlConnection cn = new SqlConnection(rutaBDLibreria);
        try
        {
            cn.Open();
            return cn;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public SqlDataAdapter ObtenerAdaptador(String consultaSql)
    {
        SqlDataAdapter adaptador;
        try
        {
            adaptador=new SqlDataAdapter(consultaSql,ObtenerConexion());
            return adaptador;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public void aplicarconsultasql( String Sql)
    {
        String NombreTabla = "asd";
           DataSet ds = new DataSet();
        SqlConnection cn = ObtenerConexion();
        SqlDataAdapter adp = ObtenerAdaptador(Sql);
        adp.Fill(ds, NombreTabla);
    }
    public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP) //comando que recibe tiene los parametros incluidos
    {
        int FilasCambiadas;
        SqlConnection Conexion = ObtenerConexion();
        SqlCommand cmd = new SqlCommand();
        cmd = Comando;
        cmd.Connection = Conexion;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = NombreSP;
        FilasCambiadas = cmd.ExecuteNonQuery();
        Conexion.Close();
        return FilasCambiadas;
    }
    public string Obtenercampo(String Nombre, String Sql)
    {
        DataSet ds = new DataSet();
        AccesoDatos datos = new AccesoDatos();
        SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
        adp.Fill(ds, Nombre);
        if (ds.Tables[Nombre].Rows.Count != 0)
            return ds.Tables[Nombre].Rows[0][0].ToString();
        else { return ""; }
    }


}