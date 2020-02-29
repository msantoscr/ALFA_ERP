using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ALFA_ERP.VISTAS
{
    public partial class frm_MovimientoConcentrado : Form
    {
        string usuario = "";
        Metodos mtd = new Metodos();
        DataSet objClientes = new DataSet();
        DataSet objEmp = new DataSet();
        DataSet objConcepto = new DataSet();
        DataSet objIva = new DataSet();
        DataSet objMaquila = new DataSet();
        DataSet objBroker = new DataSet();
        DataSet objSocio = new DataSet();
        DataSet objDirector = new DataSet();
        public frm_MovimientoConcentrado(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void TXT_IVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frm_MovimientoConcentrado_Load(object sender, EventArgs e)
        {
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            LBL_FECHA.Text = "Fecha: " + fechaActual.ToString();

            objClientes = mtd.getClientesConcentrado();
            foreach (DataRow row in objClientes.Tables[0].Rows)
            {
                CMB_CLIENTE.Items.Add(row[0].ToString());
            }
            CMB_CLIENTE.SelectedIndex = 0;

            objEmp = mtd.getEmpresasConcentrado();
            foreach (DataRow row in objEmp.Tables[0].Rows)
            {
                CMB_EMP_FAC.Items.Add(row[0].ToString());
            }
            CMB_EMP_FAC.SelectedIndex = 0;

            objConcepto = mtd.getConceptoConcentrado();
            foreach (DataRow row in objConcepto.Tables[0].Rows)
            {
                CMB_CONCEPTO.Items.Add(row[0].ToString());
            }
            CMB_CONCEPTO.SelectedIndex = 0;

            objIva = mtd.getIva();
            foreach (DataRow row in objIva.Tables[0].Rows)
            {
                CMB_IVA.Items.Add(row[0].ToString());
            }
            CMB_IVA.SelectedIndex = 0;

            objMaquila = mtd.getMaquila();
            foreach (DataRow row in objMaquila.Tables[0].Rows)
            {
                CMB_MAQUILA.Items.Add(row[0].ToString());
            }
            CMB_MAQUILA.SelectedIndex = 0;

            objBroker = mtd.getBroker();
            foreach (DataRow row in objBroker.Tables[0].Rows)
            {
                CMB_BROKER.Items.Add(row[0].ToString());
            }
            CMB_BROKER.SelectedIndex = 0;

            objSocio = mtd.getSocios();
            foreach (DataRow row in objSocio.Tables[0].Rows)
            {
                CMB_SOCIOS.Items.Add(row[0].ToString());
            }
            CMB_SOCIOS.SelectedIndex = 0;

            objDirector = mtd.getDirectores();
            foreach (DataRow row in objDirector.Tables[0].Rows)
            {
                CMB_DIRECTOR.Items.Add(row[0].ToString());
            }
            CMB_DIRECTOR.SelectedIndex = 0;
        }

        private void CMB_CLIENTE_SelectedIndexChanged(object sender, EventArgs e)
        {
            porcentajeComisionCliente();
            porcentajeComision20();
            if (TXT_PORCENT_CLIENTE.Text == "" || TXT_PORCENT_CLIENTE == null)
            {
                MessageBox.Show("EL CAMPO PORCENTAJE CLIENTE NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TXT_COMISION_20.Text == "" || TXT_COMISION_20 == null)
            {
                MessageBox.Show("EL CAMPO PORCENTAJE 2.0 NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void porcentajeComisionCliente()
        {
            try
            {
                mtd.abrirConexion();
                mtd.cmd = new SqlCommand("SP_OBTENER_PORCENTAJE_CLIENTE", mtd.conexion);
                mtd.cmd.CommandType = CommandType.StoredProcedure;
                mtd.cmd.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = Convert.ToInt32(CMB_CLIENTE.Text.Split('*').GetValue(0).ToString().Trim());
                mtd.lector = mtd.cmd.ExecuteReader();

                if (mtd.lector.Read())
                {
                    TXT_PORCENT_CLIENTE.Text = Convert.ToString(mtd.lector["PORCENTAJE_COMISION_CLIENTE"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mtd.cerrarConexion();
            }

        }

        public void porcentajeComisionMaquila()
        {
            try
            {
                mtd.abrirConexion();
                mtd.cmd = new SqlCommand("SP_OBTENER_PORCENTAJE_MAQUILA", mtd.conexion);
                mtd.cmd.CommandType = CommandType.StoredProcedure;
                mtd.cmd.Parameters.Add("@ID_MAQUILA", SqlDbType.Int).Value = Convert.ToInt32(CMB_MAQUILA.Text.Split('*').GetValue(0).ToString().Trim());
                mtd.lector = mtd.cmd.ExecuteReader();

                if (mtd.lector.Read())
                {
                    TXT_COMISION_MAQUILA.Text = Convert.ToString(mtd.lector["PORCENTAJE_COMISION"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mtd.cerrarConexion();
            }

        }

        public void porcentajeComisionBroker()
        {
            try
            {
                mtd.abrirConexion();
                mtd.cmd = new SqlCommand("SP_OBTENER_PORCENTAJE_BROKER", mtd.conexion);
                mtd.cmd.CommandType = CommandType.StoredProcedure;
                mtd.cmd.Parameters.Add("@ID_BROKER", SqlDbType.Int).Value = Convert.ToInt32(CMB_BROKER.Text.Split('*').GetValue(0).ToString().Trim());
                mtd.lector = mtd.cmd.ExecuteReader();

                if (mtd.lector.Read())
                {
                    TXT_COMISION_BROKER.Text = Convert.ToString(mtd.lector["PORCENTAJE_COMISION_BROKER"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mtd.cerrarConexion();
            }

        }

        public void porcentajeComisionSocio()
        {
            try
            {
                mtd.abrirConexion();
                mtd.cmd = new SqlCommand("SP_OBTENER_PORCENTAJE_SOCIOS", mtd.conexion);
                mtd.cmd.CommandType = CommandType.StoredProcedure;
                mtd.cmd.Parameters.Add("@ID_SOCIO", SqlDbType.Int).Value = Convert.ToInt32(CMB_SOCIOS.Text.Split('*').GetValue(0).ToString().Trim());
                mtd.lector = mtd.cmd.ExecuteReader();

                if (mtd.lector.Read())
                {
                    TXT_COMISION_SOCIO.Text = Convert.ToString(mtd.lector["PORCENTAJE_COMISION_SOCIO"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mtd.cerrarConexion();
            }

        }

        public void porcentajeComisionDirector()
        {
            try
            {
                mtd.abrirConexion();
                mtd.cmd = new SqlCommand("SP_OBTENER_PORCENTAJE_DIRECTOR", mtd.conexion);
                mtd.cmd.CommandType = CommandType.StoredProcedure;
                mtd.cmd.Parameters.Add("@ID_DIRECTOR", SqlDbType.Int).Value = Convert.ToInt32(CMB_DIRECTOR.Text.Split('*').GetValue(0).ToString().Trim());
                mtd.lector = mtd.cmd.ExecuteReader();

                if (mtd.lector.Read())
                {
                    TXT_COMISION_DIRECTOR.Text = Convert.ToString(mtd.lector["PORCENTAJE_COMISION_DIRECTOR"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mtd.cerrarConexion();
            }

        }

        public void porcentajeComision20()
        {
            try
            {
                mtd.abrirConexion();
                mtd.cmd = new SqlCommand("SP_OBTENER_PORCENTAJE_COMISION20", mtd.conexion);
                mtd.cmd.CommandType = CommandType.StoredProcedure;
                mtd.cmd.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = Convert.ToInt32(CMB_CLIENTE.Text.Split('*').GetValue(0).ToString().Trim());
                mtd.lector = mtd.cmd.ExecuteReader();

                if (mtd.lector.Read())
                {
                    TXT_COMISION_20.Text = Convert.ToString(mtd.lector["PORCENTAJE_COMISION_2_0"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mtd.cerrarConexion();
            }
        }

        private void CMB_MAQUILA_SelectedIndexChanged(object sender, EventArgs e)
        {
            porcentajeComisionMaquila();
            if (TXT_COMISION_MAQUILA.Text == "")
            {
                MessageBox.Show("EL CAMPO PORCENTAJE MAQUILA NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CMB_BROKER_SelectedIndexChanged(object sender, EventArgs e)
        {
            porcentajeComisionBroker();
            if (TXT_COMISION_BROKER.Text == "")
            {
                MessageBox.Show("EL CAMPO PORCENTAJE BROKER NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CMB_SOCIOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            porcentajeComisionSocio();
            if (TXT_COMISION_SOCIO.Text == "")
            {
                MessageBox.Show("EL CAMPO PORCENTAJE SOCIO NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CMB_DIRECTOR_SelectedIndexChanged(object sender, EventArgs e)
        {
            porcentajeComisionDirector();
            if (TXT_COMISION_DIRECTOR.Text == "")
            {
                MessageBox.Show("EL CAMPO PORCENTAJE DIRECTOR NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TXT_IMPORTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                calcularSubTotal();
            }

        }
        public void calcularSubTotal()
        {
            if (TXT_IMPORTE.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());
                double Iva = (Convert.ToDouble(CMB_IVA.Text.Split('*').GetValue(1).ToString().Trim()) / 100);

                double Calculo = importe / (1 + Iva);
                double num = (Math.Truncate(Calculo * 100) / 100);
                TXT_SUBTOTAL.Text = string.Format("{0:0,0.00}", num);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE NO PUEDE DEJARLO VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularTotalIva()
        {
            if (TXT_IMPORTE.Text != "" && TXT_SUBTOTAL.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double subtotal = Convert.ToDouble(TXT_SUBTOTAL.Text);

                double iva = importe - subtotal;

                TXT_TOTAL_IVA.Text = string.Format("{0:0,0.00}", iva);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y SUBOTAL NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void calcularTotaMaquila()
        {
            if (TXT_IMPORTE.Text != "" && TXT_COMISION_MAQUILA.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double costo_maquila = Convert.ToDouble(TXT_COMISION_MAQUILA.Text) / 100;

                double totalMaquila = importe * costo_maquila;

                TXT_TOTAL_MAQUILA.Text = string.Format("{0:0,0.00}", totalMaquila);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y COMISION MAQUILA NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularTotalSaldoMaquila()
        {
            if (TXT_IMPORTE.Text != "" && TXT_TOTAL_MAQUILA.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double total_comision_maquila = Convert.ToDouble(TXT_TOTAL_MAQUILA.Text);

                double totalMaquila = importe - total_comision_maquila;

                TXT_SALDO_MAQUILA.Text = string.Format("{0:0,0.00}", totalMaquila);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y COMISION MAQUILA NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularComisionCliente()
        {
            if (TXT_IMPORTE.Text != "" && TXT_PORCENT_CLIENTE.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double total_comision_cliente = Convert.ToDouble(TXT_PORCENT_CLIENTE.Text) / 100;

                double clienteComi = importe * total_comision_cliente;

                TXT_TOTAL_CLIENTE.Text = string.Format("{0:0,0.00}", clienteComi);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y COMISION CLIENTE NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularTotalDevoCliente()
        {
            if (TXT_IMPORTE.Text != "" && TXT_TOTAL_CLIENTE.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double total_cliente = Convert.ToDouble(TXT_TOTAL_CLIENTE.Text);

                double devCliente = importe - total_cliente;

                TXT_DEVO_CLIENTE.Text = string.Format("{0:0,0.00}", devCliente);
                TXT_SALDO_CLIENTE.Text = string.Format("{0:0,0.00}", devCliente);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y COMISION CLIENTE NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularComisionBroker()
        {
            if (TXT_IMPORTE.Text != "" && TXT_COMISION_BROKER.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double total_comision_broker = Convert.ToDouble(TXT_COMISION_BROKER.Text) / 100;

                double brokerComi = importe * total_comision_broker;

                TXT_TOTAL_BROKER.Text = string.Format("{0:0,0.00}", brokerComi);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y COMISION BROKER NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularComision20()
        {
            if (TXT_IMPORTE.Text != "" && TXT_COMISION_20.Text != "")
            {
                double importe = Convert.ToDouble(TXT_IMPORTE.Text.ToString().Trim());

                double total_comision_20 = Convert.ToDouble(TXT_COMISION_20.Text) / 100;

                double comision20 = importe * total_comision_20;

                TXT_TOTAL_COMISION20.Text = string.Format("{0:0,0.00}", comision20);

            }
            else
            {
                MessageBox.Show("EL CAMPO IMPORTE Y COMISION 2.0 NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularComisionSocio()
        {
            if (TXT_TOTAL_COMISION20.Text != "" && TXT_COMISION_SOCIO.Text != "")
            {
                double comi20 = Convert.ToDouble(TXT_TOTAL_COMISION20.Text.ToString().Trim());

                double total_comisionSocio = Convert.ToDouble(TXT_COMISION_SOCIO.Text) / 100;

                double comisionSocio = comi20 * total_comisionSocio;

                TXT_TOTAL_SOCIO.Text = string.Format("{0:0,0.00}", comisionSocio);

            }
            else
            {
                MessageBox.Show("EL CAMPO COMISION 2.0 Y COMISION SOCIO NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularComisionDirector()
        {
            if (TXT_TOTAL_COMISION20.Text != "" && TXT_COMISION_DIRECTOR.Text != "")
            {
                double comi20 = Convert.ToDouble(TXT_TOTAL_COMISION20.Text.ToString().Trim());

                double total_comisionDirector = Convert.ToDouble(TXT_COMISION_DIRECTOR.Text) / 100;

                double comisionDirector = comi20 * total_comisionDirector;

                TXT_TOTAL_DIRECTOR.Text = string.Format("{0:0,0.00}", comisionDirector);

            }
            else
            {
                MessageBox.Show("EL CAMPO COMISION 2.0 Y COMISION SOCIO NO PUEDE QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void calcularUtilidad()
        {
            if (TXT_TOTAL_MAQUILA.Text != "" && TXT_TOTAL_CLIENTE.Text != "" && TXT_TOTAL_BROKER.Text != "" && TXT_TOTAL_SOCIO.Text != "" && TXT_TOTAL_DIRECTOR.Text != "")
            {
                double maqui = Convert.ToDouble(TXT_SALDO_MAQUILA.Text.ToString().Trim());
                double clien = Convert.ToDouble(TXT_DEVO_CLIENTE.Text.ToString().Trim());
                double broker = Convert.ToDouble(TXT_TOTAL_BROKER.Text.ToString().Trim());
                double socio = Convert.ToDouble(TXT_TOTAL_SOCIO.Text.ToString().Trim());
                double director = Convert.ToDouble(TXT_TOTAL_DIRECTOR.Text.ToString().Trim());

                double result = maqui - clien - broker - socio - director;

                TXT_UTILIDADES.Text = string.Format("{0:0,0.00}", result);

            }
            else
            {
                MessageBox.Show("ALGUNOS TOTALES NO PUEDEN QUEDAR VACIO", "ALFA_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void BTN_CALCULAR_Click(object sender, EventArgs e)
        {

            calcularSubTotal();
            calcularTotalIva();
            calcularTotaMaquila();
            calcularTotalSaldoMaquila();
            calcularComisionCliente();
            calcularTotalDevoCliente();
            calcularComisionBroker();
            calcularComision20();
            calcularComisionSocio();
            calcularComisionDirector();
            calcularUtilidad();
            
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TXT_COMISION_MAQUILA.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR LA COMISION DE MAQUILA!", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_PORCENT_CLIENTE.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL PORCENTAJE DEL CLIENTE!", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_TIPO_DEV.Text =="") {
                MessageBox.Show("DEBE INGRESAR EL TIPO DEVOLUCION!", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_STATUS_DEV.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL STATUS DEVOLUCION!", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int factura = 0;
                if (RBT_FACTURADO_NO.Checked == true)
                {
                    factura = 0;
                }
                else if (RBT_FACTURADO_SI.Checked == true)
                {
                    factura = 1;
                }
                int result = 0;
                
                    
                result = mtd.INSERTAR_CONCENTRADO(
                    Convert.ToInt32(CMB_CLIENTE.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToInt32(CMB_EMP_FAC.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToInt32(CMB_CONCEPTO.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToDecimal(TXT_IMPORTE.Text),
                    Convert.ToInt32(CMB_IVA.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToDecimal(TXT_SUBTOTAL.Text),
                    factura,
                    Convert.ToInt32(CMB_MAQUILA.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToDecimal(TXT_COMISION_MAQUILA.Text),
                    Convert.ToDecimal(TXT_TOTAL_MAQUILA.Text), 
                    Convert.ToDecimal(TXT_SALDO_MAQUILA.Text), 
                    Convert.ToDecimal(TXT_PORCENT_CLIENTE.Text),
                    Convert.ToDecimal(TXT_TOTAL_CLIENTE.Text), 
                    Convert.ToDecimal(TXT_DEVO_CLIENTE.Text), 
                    TXT_TIPO_DEV.Text,
                    TXT_STATUS_DEV.Text, 
                    Convert.ToInt32(CMB_BROKER.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToDecimal(TXT_COMISION_BROKER.Text),
                    Convert.ToDecimal(TXT_TOTAL_BROKER.Text),
                    TXT_STATUS_BROKER.Text,
                    Convert.ToDecimal(TXT_COMISION_20.Text),
                    Convert.ToDecimal(TXT_TOTAL_COMISION20.Text),
                    Convert.ToInt32(CMB_SOCIOS.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToDecimal(TXT_COMISION_SOCIO.Text),
                    Convert.ToDecimal(TXT_TOTAL_SOCIO.Text),TXT_STATUS_SOCIO.Text,
                    Convert.ToDecimal(TXT_COMISION_DIRECTOR.Text),
                    Convert.ToInt32(CMB_DIRECTOR.Text.Split('*').GetValue(0).ToString().Trim()),
                    Convert.ToDecimal(TXT_TOTAL_DIRECTOR.Text),
                    TXT_STATUS_DIRECTOR.Text,
                    Convert.ToDecimal(TXT_UTILIDADES.Text),
                    Convert.ToDecimal(TXT_SALDO_CLIENTE.Text),
                    TXT_OBSERVACIONES.Text,usuario
                    );

                if (result == 1)
                {

                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
