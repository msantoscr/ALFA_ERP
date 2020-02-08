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
    public partial class Broker : Form
    {
        Metodos mtd = new Metodos();
        DataSet objPais = new DataSet();
        DataSet objEstados = new DataSet();
        DataSet objMunicipios = new DataSet();
        string usuario = "";
        public Broker(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Broker_Load(object sender, EventArgs e)
        {
            mtd.reporteBroker(dgvBrokers);

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
            TXT_GIRO.ResetText();
            TXT_NOMBRE.ResetText();
            TXT_RFC.ResetText();
            TXT_TELEFONO.ResetText();
            TXT_WEB_SITE.ResetText();
            TXT_ID.ResetText();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = mtd.insertaBroker(
                     TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RFC.Text.ToString().Trim(),
                     TXT_WEB_SITE.Text.ToString().Trim(),
                     TXT_TELEFONO.Text.ToString().Trim(),
                     TXT_GIRO.Text.ToString().Trim(),
                     Convert.ToInt32(CMB_MUNICIPIO.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_ESTADO.Text.Split('*').GetValue(0).ToString().Trim()),
                     usuario
                     );

                if (result == 1)
                {

                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESET_CONTROLS();
                    mtd.reporteBroker(dgvBrokers);
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
                if (dgvBrokers.SelectedRows.Count > 0)
                {
                    int result = 0;
                    result = mtd.actualizaBroker(
                     TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RFC.Text.ToString().Trim(),
                     TXT_WEB_SITE.Text.ToString().Trim(),
                     TXT_TELEFONO.Text.ToString().Trim(),
                     TXT_GIRO.Text.ToString().Trim(),
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
                        mtd.reporteBroker(dgvBrokers);
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

        private void dgvBrokers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBrokers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGuardar.Enabled = false;
                dgvBrokers.CurrentRow.Selected = true;

                TXT_NOMBRE.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_NOMBRE"].Value.ToString();
                TXT_RFC.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_RFC"].Value.ToString();
                TXT_WEB_SITE.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_WEB"].Value.ToString();
                TXT_TELEFONO.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_TELEFONO"].Value.ToString();
                TXT_GIRO.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_GIRO"].Value.ToString();
                TXT_ID.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_ID"].Value.ToString();
                CMB_PAIS.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_PAIS"].Value.ToString();
                CMB_ESTADO.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_ESTADO"].Value.ToString();
                CMB_MUNICIPIO.Text = dgvBrokers.Rows[e.RowIndex].Cells["BROKER_MUNICIPIO"].Value.ToString();
            }
        }
    }
}
