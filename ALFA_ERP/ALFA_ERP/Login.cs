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

        private void TXT_PASSWORD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TXT_USER.Text == "" || TXT_USER == null)
                {
                    MessageBox.Show("no puede quedar vacio el campo nombre de usuario", "ALFA ERP..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        string contra = mtd.existeContra(TXT_USER.Text.ToString().Trim());
                        if (contra.Equals(TXT_PASSWORD.Text.ToString().Trim())==true)
                        {
                            this.Hide();
                            VISTAS.Menu frn_menu = new VISTAS.Menu();
                            frn_menu.Show();
                        }else
                        {
                            MessageBox.Show("CONTRASEÑA INVALIDA", "ALFA ERP..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TXT_USER.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO:--" + TXT_USER.Text + "--NO SE ENCUENTRA REGISTRADO O SU CUENTA ESTA DESACTIVADA","ALFA ERP..",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        TXT_USER.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Ocurrio un error al entrar al sistema!!", "ALFA ERP..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                    mtd.cerrarConexion();
                    TXT_PASSWORD.ResetText();
                    TXT_USER.ResetText();

                }
            }
        }
    }
}
