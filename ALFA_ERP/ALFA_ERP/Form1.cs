using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALFA_ERP
{
    public partial class frm_acceso : Form
    {
        Metodos mtd = new Metodos();
        public frm_acceso()
        {
            InitializeComponent();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            if (TXT_USER.Text == "" || TXT_USER ==null )
            {
                MessageBox.Show("no puede quedar vacio el campo nombre de usuario","ALFA ERP..",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TXT_USER.Focus();
                return;
                
            }
            if (TXT_PASSWORD.Text == "" || TXT_PASSWORD == null)
            {
                MessageBox.Show("no puede quedar vacio el campo password", "ALFA ERP..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_USER.Focus();
                return;
                
            }
            try
            {
                mtd.abrirConexion();
                if (mtd.usuarioRegistrado(TXT_USER.Text.ToString().Trim()) == true)
                {
                    MessageBox.Show("se encontro!!");
                }else
                {
                    MessageBox.Show("no se encontro!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Ocurrio un error al entrar al sistema!!", "ALFA ERP..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally {
                mtd.cerrarConexion();
                TXT_PASSWORD.ResetText();
                TXT_USER.ResetText();

            }
        }
    }
}
