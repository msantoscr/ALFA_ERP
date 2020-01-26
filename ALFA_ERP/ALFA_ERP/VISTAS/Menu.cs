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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            DiseñoActualizado();
        }

        private void DiseñoActualizado()
        {
            panelClientesSubMenu.Visible = false;
            panelEmpresasSubMenu.Visible = false;
            panelConceptosSubMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelClientesSubMenu.Visible == true)
                panelClientesSubMenu.Visible = false;
            if (panelEmpresasSubMenu.Visible == true)
                panelEmpresasSubMenu.Visible = false;
            if (panelConceptosSubMenu.Visible == true)
                panelConceptosSubMenu.Visible = false;

        }


        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

       


        #region "SUBMENU CLIENTES"
        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelClientesSubMenu);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            //...
            abrirHijoForm(new VISTAS.Clientes());
            //
            OcultarSubMenu();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            //...
            //mi codigo
            //
            OcultarSubMenu();
        }
        #endregion

        #region "SUBMENU EMPRESAS"
        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelEmpresasSubMenu);
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            //...
            //mi codigo
            //
            OcultarSubMenu();
        }

        private void btnReporteEmpresas_Click(object sender, EventArgs e)
        {
            //...
            //mi codigo
            //
            OcultarSubMenu();
        }

        #endregion

        #region "SUBMENU CONCEPTOS"
        private void btnConceptos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelConceptosSubMenu);

        }

        private void btnNuevoConcepto_Click(object sender, EventArgs e)
        {
            //...
            //mi codigo
            //
            OcultarSubMenu();
        }

        private void btnReporteConceptos_Click(object sender, EventArgs e)
        {
            //...
            //mi codigo
            //
            OcultarSubMenu();
        }

        #endregion

        private Form activeForm = null;
        private void abrirHijoForm(Form formularioHijo)
        {
            if (activeForm != null)
                //ALMACENAMOS EL FORMULARIO ACTIVO LO CERRAMOS Y ABRIMOS EL NUEVO FORMULARIO HIJO
                activeForm.Close();
                activeForm = formularioHijo;

                //EL FORMULARIO HIJO NO ES DE NIVEL SUPERIOR POR LO TANTO SE COMPORTARA COMO UN CONTROL
                formularioHijo.TopLevel = false;
                formularioHijo.FormBorderStyle = FormBorderStyle.None;
                formularioHijo.Dock = DockStyle.Fill;
                panelFormHijo.Controls.Add(formularioHijo);
                //asociamos el formulario con el panel contenedor
                panelFormHijo.Tag = formularioHijo;
                //traer el formulario hacia enfrente SI HAY UN LOGO ENCIMA
                formularioHijo.BringToFront();
                //mostramos el formulario
                formularioHijo.Show();
            
        }
    }
}
