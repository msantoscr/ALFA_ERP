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
    public partial class Empresas : Form
    {
        Metodos mtd = new Metodos();
        DataSet objPaises = new DataSet();
        DataSet objEstados = new DataSet();
        DataSet objMunicipios = new DataSet();
        string usuario;
        public Empresas(string usu)
        {
            InitializeComponent();
            usuario = usu;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = mtd.INSERTAR_EMPRESA(
                     TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RAZON_SOCIAL.Text.ToString().Trim(),
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
                     usuario
                     );

                if (result == 1)
                {

                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESET_CONTROLS();
                    mtd.reporteEmpresa(dgvEmpresas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            mtd.reporteEmpresa(dgvEmpresas);

            objPaises = mtd.getPaises();
            foreach (DataRow row in objPaises.Tables[0].Rows)
            {
                CMB_PAIS.Items.Add(row[0].ToString());
            }
            CMB_PAIS.SelectedIndex = 0;
            CMB_ESTADO.SelectedIndex = 0;

            TXT_NOMBRE.Focus();
        }

        public void RESET_CONTROLS()
        {
            TXT_CALLE.ResetText();
            TXT_COLONIA.ResetText();
            TXT_CORREO.ResetText();
            TXT_CP.ResetText();
            TXT_NOMBRE.ResetText();
            TXT_NUM_EXT.ResetText();
            TXT_NUM_INT.ResetText();
            TXT_RAZON_SOCIAL.ResetText();
            TXT_RFC.ResetText();
            TXT_TELEFONO.ResetText();
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

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgvEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpresas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGuardar.Enabled = false;
                dgvEmpresas.CurrentRow.Selected = true;

                TXT_NOMBRE.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_NOMBRE"].Value.ToString();
                TXT_CALLE.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_CALLE"].Value.ToString();
                TXT_CP.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_CP"].Value.ToString();
                TXT_COLONIA.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_COLONIA"].Value.ToString();
                TXT_NUM_EXT.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_NUM_EXT"].Value.ToString();
                TXT_NUM_INT.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_NUM_INT"].Value.ToString();
                TXT_RFC.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_RFC"].Value.ToString();
                TXT_TELEFONO.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_TELEFONO"].Value.ToString();
                TXT_CORREO.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_CORREO"].Value.ToString();
                TXT_RAZON_SOCIAL.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_RAZON_SOCIAL"].Value.ToString();
                TXT_ID.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_ID"].Value.ToString();
                CMB_PAIS.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_PAIS"].Value.ToString();
                CMB_ESTADO.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_ESTADO"].Value.ToString();
                CMB_MUNICIPIO.Text = dgvEmpresas.Rows[e.RowIndex].Cells["EMPRESA_MUNICIPIO"].Value.ToString();
            }
        }

        private void TXT_NOMBRE_Leave(object sender, EventArgs e)
        {
            TXT_COLONIA.Focus();
        }

        private void TXT_COLONIA_Leave(object sender, EventArgs e)
        {
            TXT_CP.Focus();
        }

        private void TXT_CP_Leave(object sender, EventArgs e)
        {
            TXT_CALLE.Focus();
        }

        private void TXT_CALLE_Leave(object sender, EventArgs e)
        {
            TXT_NUM_EXT.Focus();
        }

        private void TXT_NUM_EXT_Leave(object sender, EventArgs e)
        {
            TXT_NUM_INT.Focus();

        }

        private void TXT_NUM_INT_Leave(object sender, EventArgs e)
        {
            TXT_RFC.Focus();
        }

        private void TXT_RFC_Leave(object sender, EventArgs e)
        {
            TXT_TELEFONO.Focus();
        }

        private void TXT_TELEFONO_Leave(object sender, EventArgs e)
        {
            TXT_CORREO.Focus();
        }

        private void TXT_CORREO_Leave(object sender, EventArgs e)
        {
            TXT_RAZON_SOCIAL.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpresas.SelectedRows.Count > 0)
                {
                    int result = 0;
                    result = mtd.actualizaEmpresa(
                         TXT_NOMBRE.Text.ToString().Trim(),
                         TXT_RAZON_SOCIAL.Text.ToString().Trim(),
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
                         usuario,
                         Convert.ToInt32(TXT_ID.Text.ToString().Trim())
                         );

                    if (result == 1)
                    {

                        MessageBox.Show("ACTUALIZADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RESET_CONTROLS();
                        mtd.reporteEmpresa(dgvEmpresas);
                        btnGuardar.Enabled = true;     
                            }
                }
                else
                {
                    MessageBox.Show("NO SELECCIONO NINGUN DATO", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                btnGuardar.Enabled = true;
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
