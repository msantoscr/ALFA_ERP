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
                cmd.Parameters.Add("@NOMBRE_USER", SqlDbType.NVarChar, 300).Value = user;

                lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    result = true;
                }
                lector.Close();
            }
            catch (Exception ex)
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
                MessageBox.Show(ex.Message, "ERROR..");
            }
            return resultado;
        }

        #endregion

        

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
                cmd = new SqlCommand("SP_OBTENER_PAISES", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
#region "CLIENTES"
        public int INSERTAR_CLIENTE(string nombre, string razon, string nomComercial, string rfc, string calle, string numInt, string numExt, string colonia, string codigoP, int municipio, int pais, int estado, string telefono, string correo, string userModifica)
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

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
               
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
             
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
               
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
                
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);
             
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

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        #region "CONCEPTOS"

        public void reporteConceptos(DataGridView dgv)
        {

            try
            {
                abrirConexion();
                cmd = new SqlCommand("SP_REPORTE_CONCEPTOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter Message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 200);
                Message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(Message);

                adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR..");
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int INSERTAR_CONCEPTO(string descripcion, string userModifica)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVO_CONCEPTO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar).Value = descripcion;
                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        #region "MAQUILAS"

        public void reporteMaquila(DataGridView grid)
        {
            try
            {
                cmd = new SqlCommand("SP_REPORTE_MAQUILAS", conexion);
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

        public int insertaMaquila(string nombre,string rfc, string calle, string numInt, string numExt, string colonia, int municipio, int pais, int estado, string userModifica)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVA_MAQUILA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_MAQUILA", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = calle;
                cmd.Parameters.Add("@NUMERO_EXTERIOR", SqlDbType.NVarChar).Value = numExt;
                cmd.Parameters.Add("@NUMERO_INTERIOR", SqlDbType.NVarChar).Value = numInt;
                cmd.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = colonia;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        public int actualizaMaquila(string nombre, string rfc, string calle, string numInt, string numExt, string colonia, int municipio, int pais, int estado, string userModifica, int id)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_ACTUALIZA_MAQUILA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_MAQUILA", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@CALLE", SqlDbType.NVarChar).Value = calle;
                cmd.Parameters.Add("@NUMERO_EXTERIOR", SqlDbType.NVarChar).Value = numExt;
                cmd.Parameters.Add("@NUMERO_INTERIOR", SqlDbType.NVarChar).Value = numInt;
                cmd.Parameters.Add("@COLONIA", SqlDbType.NVarChar).Value = colonia;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        #region "BROKERS"
        public void reporteBroker(DataGridView grid)
        {
            try
            {
                cmd = new SqlCommand("SP_REPORTE_BROKERS", conexion);
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

        public int insertaBroker(string nombre, string rfc, string web, string telefono, string giro, int municipio, int pais, int estado, string userModifica)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVO_BROKER", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_BROKER", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@BROKER_WEB", SqlDbType.NVarChar).Value = web;
                cmd.Parameters.Add("@BROKER_GIRO", SqlDbType.NVarChar).Value = giro;
                cmd.Parameters.Add("@BROKER_TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        public int actualizaBroker(string nombre, string rfc, string web, string telefono, string giro, int municipio, int pais, int estado, string userModifica, int id)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_ACTUALIZA_BROKER", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_BROKER", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@BROKER_WEB", SqlDbType.NVarChar).Value = web;
                cmd.Parameters.Add("@BROKER_GIRO", SqlDbType.NVarChar).Value = giro;
                cmd.Parameters.Add("@BROKER_TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        #region "SOCIOS"
        public void reporteSocios(DataGridView grid)
        {
            try
            {
                cmd = new SqlCommand("SP_REPORTE_SOCIOS", conexion);
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

        public int insertaSocio(string nombre, string rfc, string correo, string telefono, int municipio, int pais, int estado, string userModifica)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVO_SOCIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_SOCIO", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@SOCIO_CORREO", SqlDbType.NVarChar).Value = correo;
                cmd.Parameters.Add("@SOCIO_TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        public int actualizaSocio(string nombre, string rfc, string correo, string telefono, int municipio, int pais, int estado, string userModifica, int id)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_ACTUALIZA_SOCIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@NOMBRE_SOCIO", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@RFC", SqlDbType.NVarChar).Value = rfc;
                cmd.Parameters.Add("@SOCIO_TELEFONO", SqlDbType.NVarChar).Value = telefono;
                cmd.Parameters.Add("@SOCIO_CORREO", SqlDbType.NVarChar).Value = correo;
                cmd.Parameters.Add("@CIUDAD", SqlDbType.Int).Value = municipio;
                cmd.Parameters.Add("@PAIS", SqlDbType.Int).Value = pais;
                cmd.Parameters.Add("@ESTADO", SqlDbType.Int).Value = estado;

                cmd.Parameters.Add("@MODIFICADOPOR", SqlDbType.NVarChar, 200).Value = userModifica;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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

        #region "CONCENTRADO"

        public DataSet getClientesConcentrado()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_CLIENTES", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getEmpresasConcentrado()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_EMPRESAS", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getConceptoConcentrado()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_CONCEPTOS", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getIva()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_IVA", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getMaquila()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_MAQUILAS", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getBroker()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_BROKERS", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getSocios()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_SOCIOS", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public DataSet getDirectores()
        {
            abrirConexion();
            try
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand("SP_OBTENER_DIRECTOR", conexion);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cerrarConexion();
            }
        }

        public int INSERTAR_CONCENTRADO(int idCliente, int idEmpresa, int idConcepto, decimal importeNeto, 
            int porcentajeIva,decimal subtotal,int facturaSiNo, int idMaquila, decimal porcentajeMaquila,
            decimal comisionMaquila, decimal saldoMaquila, decimal porcentajeCliente,decimal comisionCliente, 
            decimal devolucionCliente, string devolucion, string status, int idBroker, decimal porcentajeBroker, 
            decimal comisionBroker, string statusBroker, decimal porcentajeCosto20, decimal comision20, int idSocio,
            decimal porcentajeSocio, decimal comisionSocio, string statusComsionSocio, decimal porcentajeDirector,
            int idDirector, decimal comisionDirector, string statusDirector, decimal utilidad, decimal saldoCliente, 
            string observaciones, string usuarioModifica)
        {
            try
            {

                abrirConexion();
                cmd = new SqlCommand("SP_INSERTA_NUEVO_CONCENTRADO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
                cmd.Parameters.Add("@idEmpresa", SqlDbType.Int).Value = idEmpresa;
                cmd.Parameters.Add("@idConcepto", SqlDbType.Int).Value = idConcepto;
                cmd.Parameters.Add("@importeNeto", SqlDbType.Decimal).Value = importeNeto;
                cmd.Parameters.Add("@porcentajeIva", SqlDbType.Int).Value = porcentajeIva;
                cmd.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = subtotal;
                cmd.Parameters.Add("@facturaSiNo", SqlDbType.Int).Value = facturaSiNo;
                cmd.Parameters.Add("@idMaquila", SqlDbType.Int).Value = idMaquila;
                cmd.Parameters.Add("@porcentajeMaquila", SqlDbType.Decimal).Value = porcentajeMaquila;
                cmd.Parameters.Add("@comisionMaquila", SqlDbType.Decimal).Value = comisionMaquila;
                cmd.Parameters.Add("@saldoMaquila", SqlDbType.Decimal).Value = saldoMaquila;
                cmd.Parameters.Add("@porcentajeCliente", SqlDbType.Decimal).Value = porcentajeCliente;
                cmd.Parameters.Add("@comisionCliente", SqlDbType.Decimal).Value = comisionCliente;
                cmd.Parameters.Add("@devolucionCliente", SqlDbType.Decimal).Value = devolucionCliente;
                cmd.Parameters.Add("@devolucion", SqlDbType.NVarChar).Value = devolucion;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                cmd.Parameters.Add("@idBroker", SqlDbType.Int).Value = idBroker;
                cmd.Parameters.Add("@porcentajeBroker", SqlDbType.Decimal).Value = porcentajeBroker;
                cmd.Parameters.Add("@comisionBroker", SqlDbType.Decimal).Value = comisionBroker;
                cmd.Parameters.Add("@statusBroker", SqlDbType.NVarChar).Value = statusBroker;
                cmd.Parameters.Add("@porcentajeCosto20", SqlDbType.Decimal).Value = porcentajeCosto20;
                cmd.Parameters.Add("@comision20", SqlDbType.Decimal).Value = comision20;
                cmd.Parameters.Add("@idSocio", SqlDbType.Int).Value = idSocio;
                cmd.Parameters.Add("@porcentajeSocio", SqlDbType.Decimal).Value = porcentajeSocio;
                cmd.Parameters.Add("@comisionSocio", SqlDbType.Decimal).Value = comisionSocio;
                cmd.Parameters.Add("@statusComsionSocio", SqlDbType.NVarChar).Value = statusComsionSocio;
                cmd.Parameters.Add("@porcentajeDirector", SqlDbType.Int).Value = porcentajeDirector;
                cmd.Parameters.Add("@idDirector", SqlDbType.Int).Value = idDirector;
                cmd.Parameters.Add("@comisionDirector", SqlDbType.Decimal).Value = comisionDirector;
                cmd.Parameters.Add("@statusDirector", SqlDbType.NVarChar).Value = statusDirector;
                cmd.Parameters.Add("@utilidad", SqlDbType.Decimal).Value = utilidad;
                cmd.Parameters.Add("@saldoCliente", SqlDbType.Decimal).Value = saldoCliente;
                cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar).Value = observaciones;
                cmd.Parameters.Add("@usuarioModifica", SqlDbType.NVarChar, 200).Value = usuarioModifica;


                SqlParameter message = new SqlParameter("@MENSAJE", SqlDbType.NVarChar, 500);
                message.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(message);

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
