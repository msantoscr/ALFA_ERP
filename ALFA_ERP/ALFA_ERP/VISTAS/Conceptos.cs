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
    public partial class Conceptos : Form
    {
        string usuario;
        Metodos mtd = new Metodos();
        public Conceptos(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void Conceptos_Load(object sender, EventArgs e)
        {
            mtd.reporteConceptos(dgvConcepto);
            TXT_DESCRIPCION.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                result = mtd.INSERTAR_CONCEPTO(
                     TXT_DESCRIPCION.Text.ToString().Trim(),
                     usuario
                     );

                if (result == 1)
                {

                    MessageBox.Show("GUARDADO CORRECTAMENTE", "ALFA ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RESET_CONTROLS();
                    mtd.reporteConceptos(dgvConcepto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RESET_CONTROLS()
        {
            TXT_DESCRIPCION.ResetText();

        }
    }
}
