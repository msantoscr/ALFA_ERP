using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALFA_ERP.VISTAS
{
    public partial class Clientes : Form
    {
        Metodos mtd = new Metodos();
        string user;
        DataSet objPaises = new DataSet();
        DataSet objEstados = new DataSet();
        DataSet objMunicipios = new DataSet();
        public Clientes(string usu)
        {
            InitializeComponent();
            user = usu;
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            mtd.reporteClientes(DGV_CLIENTES);

            objPaises = mtd.getPaises();
            foreach (DataRow row in objPaises.Tables[0].Rows)
            {
                CMB_PAIS.Items.Add(row[0].ToString());
            }
            CMB_PAIS.SelectedIndex = 0;
            CMB_ESTADO.SelectedIndex = 0;

            TXT_NOMBRE.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TXT_NOMBRE.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL NOMBRE DEL CLIENTE!", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_RFC.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL RFC DEL CLIENTE!", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_CALLE.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR LA CALLE DEL DOMICILIO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_NUM_EXT.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL NUMERO EXTERIOR DEL DOMICILIO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_NUM_INT.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL NUMERO INTERIOR DEL DOMICILIO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_COLONIA.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR LA COLONIA DEL DOMICILIO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (TXT_CP.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL CODIGO POSTAL DEL DOMICILIO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CMB_ESTADO.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL ESTADO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CMB_MUNICIPIO.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL MUNICIPIO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CMB_PAIS.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL PAIS", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (CMB_ESTADO.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR EL ESTADO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int result = 0;
                result = mtd.INSERTAR_CLIENTE(
                     TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RAZON_SOCIAL.Text.ToString().Trim(),
                     TXT_NOMBRE_COMERCIAL.Text.ToString().Trim(),
                     TXT_RFC.Text.ToString().Trim(),
                     TXT_CALLE.Text.ToString().Trim(),
                     TXT_NUM_INT.Text.ToString().Trim(),
                     TXT_NUM_EXT.Text.ToString().Trim(),
                     TXT_COLONIA.Text.ToString().Trim(),
                     TXT_CP.Text.ToString().Trim(),
                     Convert.ToInt32(CMB_MUNICIPIO.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_ESTADO.Text.Split('*').GetValue(0).ToString().Trim()),
                     TXT_TELEFONO.Text.ToString().Trim(),
                     TXT_CORREO.Text.ToString().Trim(),
                     user
                     );

                if (result == 1)
                {
                    
                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESET_CONTROLS();
                    mtd.reporteClientes(DGV_CLIENTES);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CMB_PAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_ESTADO.Items.Clear();
            int pais = Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim());

            objEstados = mtd.getEstados(pais);
            foreach (DataRow row in objEstados.Tables[0].Rows)
            {

                CMB_ESTADO.Items.Add(row[0].ToString().Trim());
            }
        }

        private void CMB_ESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_MUNICIPIO.Items.Clear();
            int pais = Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim());
            int estado = Convert.ToInt32(CMB_ESTADO.Text.Split('*').GetValue(0).ToString().Trim());
            objMunicipios = mtd.getMunicipios(pais, estado);
            foreach (DataRow row in objMunicipios.Tables[0].Rows)
            {

                CMB_MUNICIPIO.Items.Add(row[0].ToString().Trim());
            }
            CMB_MUNICIPIO.SelectedIndex = 0;

        }

        public void RESET_CONTROLS()
        {
            TXT_CALLE.ResetText();
            TXT_COLONIA.ResetText();
            TXT_CORREO.ResetText();
            TXT_CP.ResetText();
            TXT_NOMBRE.ResetText();
            TXT_NOMBRE_COMERCIAL.ResetText();
            TXT_NUM_EXT.ResetText();
            TXT_NUM_INT.ResetText();
            TXT_RAZON_SOCIAL.ResetText();
            TXT_RFC.ResetText();
            TXT_TELEFONO.ResetText();
        }

        private void TXT_NOMBRE_Leave(object sender, EventArgs e)
        {
            TXT_CALLE.Focus();
        }

        private void TXT_CALLE_Leave(object sender, EventArgs e)
        {
            TXT_CP.Focus();
        }

        private void TXT_NUM_EXT_Leave(object sender, EventArgs e)
        {
            TXT_NUM_INT.Focus();
        }

        private void TXT_NUM_INT_Leave(object sender, EventArgs e)
        {
            TXT_RFC.Focus();
        }
    }
}
