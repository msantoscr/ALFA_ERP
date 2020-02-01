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

        public string existeContra(string user)
        {
            string resultado = "";
            try
            {
                cmd = new SqlCommand("SP_GET_PASSWORD_USER", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NAME_USER", SqlDbType.NVarChar, 300).Value = user;

                lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    resultado = Convert.ToString(lector["PASSWORD"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR..");
            }
            return resultado;
        }

        #endregion

        #region "CLIENTES"

        public void reporteClientes(DataGridView grid)
        {
            try
            {
                cmd = new SqlCommand("SP_REPORTE_CLIENTES", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200);
                Message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(Message);

                adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR..");
            }
        }

        public DataSet getPaises()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_PAISES",conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                Rows = cmd.ExecuteNonQuery();

                adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getEstados(int pais)
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_ESTADO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PAIS", SqlDbType.NVarChar, 200).Value = pais;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                Rows = cmd.ExecuteNonQuery();

                adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }
        public DataSet getMunicipios(int pais, int estado)
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_MUNICIPIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PAIS", SqlDbType.NVarChar, 200).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.NVarChar, 500).Value = estado;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                Rows = cmd.ExecuteNonQuery();

                adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int INSERTAR_CLIENTE(string nombre,string razon,string nomComercial,string rfc, string calle, string numInt,string numExt,string colonia, string codigoP,int municipio,int pais, int estado,string telefono,string correo,string userModifica)
        {
            try
            {
                
                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVO_CLIENTE", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_CLIENTE", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RAZONSOCIAL", SqlDbType.NVarChar).Value = razon;
                cmd.Parameters.Add("@NOMBRE_COMERCIAL", SqlDbType.NVarChar).Value = nomComercial;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = calle;
                cmd.Parameters.Add("@NUMERO_EXTERIOR", SqlDbType.NVarChar).Value = numExt;
                cmd.Parameters.Add("@NUMERO_INTERIOR", SqlDbType.NVarChar).Value = numInt;
                cmd.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = colonia;
                cmd.Parameters.Add("@CODIGO_POSTAL", SqlDbType.NVarChar).Value = codigoP;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CORREO", SqlDbType.NVarChar).Value = correo;
                //FECHA SE HARA CON GETDATE();
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                //sucursal es dentro del stored
                //ruta es dentro del stored
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int actualizaCliente(string nombre, string razon, string nomComercial, string rfc, string calle, string numInt, string numExt, string colonia, string codigoP, int municipio, int pais, int estado, string telefono, string correo, string userModifica, int id)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_ACTUALIZA_CLIENTE", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_CLIENTE", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RAZONSOCIAL", SqlDbType.NVarChar).Value = razon;
                cmd.Parameters.Add("@NOMBRE_COMERCIAL", SqlDbType.NVarChar).Value = nomComercial;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = calle;
                cmd.Parameters.Add("@NUMERO_EXTERIOR", SqlDbType.NVarChar).Value = numExt;
                cmd.Parameters.Add("@NUMERO_INTERIOR", SqlDbType.NVarChar).Value = numInt;
                cmd.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = colonia;
                cmd.Parameters.Add("@CODIGO_POSTAL", SqlDbType.NVarChar).Value = codigoP;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CORREO", SqlDbType.NVarChar).Value = correo;
                //FECHA SE HARA CON GETDATE();
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                //sucursal es dentro del stored
                //ruta es dentro del stored
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int eliminarCliente(int id)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_ELIMINAR_CLIENTE", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                //sucursal es dentro del stored
                //ruta es dentro del stored
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cerrarConexion();
            }
        }
        #endregion

        #region "EMPRESAS"

        public int INSERTAR_EMPRESA(string nombre, string razon, string rfc, string calle, string numInt, string numExt, string colonia, string codigoP, int municipio, int pais, int estado, string telefono, string correo, string userModifica)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVA_EMPRESA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_EMPRESA", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RAZONSOCIAL", SqlDbType.NVarChar).Value = razon;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = calle;
                cmd.Parameters.Add("@NUMERO_EXTERIOR", SqlDbType.NVarChar).Value = numExt;
                cmd.Parameters.Add("@NUMERO_INTERIOR", SqlDbType.NVarChar).Value = numInt;
                cmd.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = colonia;
                cmd.Parameters.Add("@CODIGO_POSTAL", SqlDbType.NVarChar).Value = codigoP;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CORREO", SqlDbType.NVarChar).Value = correo;
                //FECHA SE HARA CON GETDATE();
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                //sucursal es dentro del stored
                //ruta es dentro del stored
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public void reporteEmpresa(DataGridView grid)
        {
            try
            {
                cmd = new SqlCommand("SP_REPORTE_EMPRESAS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200);
                Message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(Message);

                adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR..");
            }
        }

        public int actualizaEmpresa(string nombre, string razon, string rfc, string calle, string numInt, string numExt, string colonia, string codigoP, int municipio, int pais, int estado, string telefono, string correo, string userModifica, int id)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_ACTUALIZA_EMPRESA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_EMPRESA", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RAZONSOCIAL", SqlDbType.NVarChar).Value = razon;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = calle;
                cmd.Parameters.Add("@NUMERO_EXTERIOR", SqlDbType.NVarChar).Value = numExt;
                cmd.Parameters.Add("@NUMERO_INTERIOR", SqlDbType.NVarChar).Value = numInt;
                cmd.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = colonia;
                cmd.Parameters.Add("@CODIGO_POSTAL", SqlDbType.NVarChar).Value = codigoP;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;
                cmd.Parameters.Add("@TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CORREO", SqlDbType.NVarChar).Value = correo;
                //FECHA SE HARA CON GETDATE();
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
                //sucursal es dentro del stored
                //ruta es dentro del stored
                cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                cerrarConexion();
            }
        }

        #endregion
    }
}
