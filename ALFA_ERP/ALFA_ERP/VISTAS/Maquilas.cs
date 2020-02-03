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
    public partial class Maquilas : Form
    {
        string usuario;

        Metodos mtd = new Metodos();
        DataSet objPaises = new DataSet();
        DataSet objEstados = new DataSet();
        DataSet objMunicipios = new DataSet();
        public Maquilas(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void Maquilas_Load(object sender, EventArgs e)
        {
            //CARGAMOS LOS DATOS DE LA TABLA POR PRIMERA VEZ
            mtd.reporteMaquila(dgvMaquilas);

            //POR MEDIO DE LOS OBJETOS TIPO DATASET OBTWMOS LOS PAISES Y LOS ESTADOS CORRESPONDIENTES
            objPaises = mtd.getPaises();
            foreach (DataRow row in objPaises.Tables[0].Rows)
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

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RESET_CONTROLS()
        {
            TXT_CALLE.ResetText();
            TXT_COLONIA.ResetText();
            TXT_NOMBRE.ResetText();
            TXT_NUM_EXT.ResetText();
            TXT_NUM_INT.ResetText();
            TXT_RFC.ResetText();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = mtd.insertaMaquila(
                     TXT_NOMBRE.Text.ToString().Trim(),
                     TXT_RFC.Text.ToString().Trim(),
                     TXT_CALLE.Text.ToString().Trim(),
                     TXT_NUM_INT.Text.ToString().Trim(),
                     TXT_NUM_EXT.Text.ToString().Trim(),
                     TXT_COLONIA.Text.ToString().Trim(),
                     Convert.ToInt32(CMB_MUNICIPIO.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_PAIS.Text.Split('*').GetValue(0).ToString().Trim()),
                     Convert.ToInt32(CMB_ESTADO.Text.Split('*').GetValue(0).ToString().Trim()),
                     usuario
                     );

                if (result == 1)
                {

                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESET_CONTROLS();
                    mtd.reporteMaquila(dgvMaquilas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaquilas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaquilas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btnGuardar.Enabled = false;
                dgvMaquilas.CurrentRow.Selected = true;

                TXT_NOMBRE.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_NOMBRE"].Value.ToString();
                TXT_CALLE.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_CALLE"].Value.ToString();
                TXT_COLONIA.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_COLONIA"].Value.ToString();
                TXT_NUM_EXT.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_NUMERO_EXT"].Value.ToString();
                TXT_NUM_INT.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_NUMERO_INT"].Value.ToString();
                TXT_RFC.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_RFC"].Value.ToString();
                TXT_ID.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_ID"].Value.ToString();
                CMB_PAIS.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_PAIS"].Value.ToString();
                CMB_ESTADO.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_ESTADO"].Value.ToString();
                CMB_MUNICIPIO.Text = dgvMaquilas.Rows[e.RowIndex].Cells["MAQUILA_MUNICIPIO"].Value.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaquilas.SelectedRows.Count > 0)
                {
                    int result = 0;
                    result = mtd.actualizaMaquila(
                         TXT_NOMBRE.Text.ToString().Trim(),
                         TXT_RFC.Text.ToString().Trim(),
                         TXT_CALLE.Text.ToString().Trim(),
                         TXT_NUM_INT.Text.ToString().Trim(),
                         TXT_NUM_EXT.Text.ToString().Trim(),
                         TXT_COLONIA.Text.ToString().Trim(),
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
                        mtd.reporteMaquila(dgvMaquilas);
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
