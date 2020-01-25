using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Windows.Forms;

namespace ALFA_ERP
{
    class Metodos
    {
        #region "VARIABLES DE CONEXION"

            public SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ALFA_ERP.Properties.Settings.ALFAConnectionString"].ConnectionString.ToString());
            public SqlCommand cmd;
            public SqlDataAdapter adaptador;
            public DataTable datatable;
            public SqlDataReader lector;
            public int Rows;
            public DataSet Dataset;

        #endregion

        #region "BASE DE DATOS"

        public void abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        #endregion

        #region Login

        public Boolean usuarioRegistrado(string user)
        {
            bool result = false;
            try
            {
                cmd = new SqlCommand("SP_GET_USER_LOGIN", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE_USER", SqlDbType.NVarChar,300).Value = user;

                lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    result = true;
                }
                lector.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            return result;
        }

        #endregion
    }
}
