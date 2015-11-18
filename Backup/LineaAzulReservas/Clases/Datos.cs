using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LineaAzulReservas.Clases
{

    /*aqui esta la clase coneccion..
     
     falta esperar lo de base de datos para empezar a trabajar 
     
     por si acaso entre hoy ó mañana nos entregan */
    public class Datos
    {

        private string cadena = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\diarioOnlineBD.mdf;Integrated Security=True";
        public SqlConnection cn;
        public SqlDataAdapter da;
        public DataSet ds = new DataSet();
        public SqlCommand comando;

        private void Conectar()
        {

            cn = new SqlConnection(cadena);
        }

        public Datos()
        {
            Conectar();
        }

        public DataTable consultaTabla(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];

            return dt;


        }

        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}