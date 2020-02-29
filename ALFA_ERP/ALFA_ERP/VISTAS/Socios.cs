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
    public partial class Socios : Form
    {
        string usuario = "";
        Metodos mtd = new Metodos();
        DataSet objPais = new DataSet();
        DataSet objEstados = new DataSet();
        DataSet objMunicipios = new DataSet();
        public Socios(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            mtd.reporteSocios(dgvSocios);

            //POR MEDIO DE LOS OBJETOS TIPO DATASET OBTWMOS LOS PAISES Y LOS ESTADOS CORRESPONDIENTES
            objPais = mtd.getPaises();
            foreach (DataRow row in objPais.Tables[0].Rows)
            {
                CMB_PAIS.Items.Add(row[0].ToString());
            }
            CMB_PAIS.SelectedIndex = 0;
            CMB_ESTADO.SelectedIndex = 0;

            TXT_NOMBRE.Focus();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
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
            TXT_NOMBRE.ResetText();
            TXT_RFC.ResetText();
            TXT_TELEFONO.ResetText();
            TXT_CORREO.ResetText();
            TXT_ID.ResetText();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = mtd.insertaSocio(
                     TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RFC.Text.ToString().Trim(),
                     TXT_CORREO.Text.ToString().Trim(),
                     TXT_TELEFONO.Text.ToString().Trim(),
                     Convert.ToInt32(CMB_MUNICIPIO.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_ESTADO.Text.Split('*').GetValue(0).ToString().Trim()),
                     usuario
                     );

                if (result == 1)
                {

                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESET_CONTROLS();
                    mtd.reporteSocios(dgvSocios);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSocios.SelectedRows.Count > 0)
                {
                    int result = 0;
                    result = mtd.actualizaSocio(
                    TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RFC.Text.ToString().Trim(),
                     TXT_CORREO.Text.ToString().Trim(),
                     TXT_TELEFONO.Text.ToString().Trim(),
                     Convert.ToInt32(CMB_MUNICIPIO.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_ESTADO.Text.Split('*').GetValue(0).ToString().Trim()),
                     usuario,
                         Convert.ToInt32(TXT_ID.Text.ToString().Trim())
                         );

                    if (result == 1)
                    {

                        MessageBox.Show("ACTUALIZADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RESET_CONTROLS();
                        mtd.reporteSocios(dgvSocios);
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

        private void dgvSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSocios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGuardar.Enabled = false;
                dgvSocios.CurrentRow.Selected = true;

                TXT_NOMBRE.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_NOMBRE"].Value.ToString();
                TXT_RFC.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_RFC"].Value.ToString();
                TXT_TELEFONO.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_TELEFONO"].Value.ToString();
                TXT_CORREO.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_CORREO"].Value.ToString();
                TXT_ID.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_ID"].Value.ToString();
                CMB_PAIS.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_PAIS"].Value.ToString();
                CMB_ESTADO.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_ESTADO"].Value.ToString();
                CMB_MUNICIPIO.Text = dgvSocios.Rows[e.RowIndex].Cells["SOCIO_MUNICIPIO"].Value.ToString();
            }
        }
    }
}
