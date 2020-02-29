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
        string user;
        public Menu(string usu)
        {
            InitializeComponent();
            DiseñoActualizado();
            user = usu;
        }

        private void DiseñoActualizado()
        {
            panelClientesSubMenu.Visible = false;
            panelEmpresasSubMenu.Visible = false;
            panelConceptosSubMenu.Visible = false;
            panelMaquilaSubMenu.Visible = false;
            panelBrokersSubMenu.Visible = false;
            panelSociosSubMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelClientesSubMenu.Visible == true)
                panelClientesSubMenu.Visible = false;
            if (panelEmpresasSubMenu.Visible == true)
                panelEmpresasSubMenu.Visible = false;
            if (panelConceptosSubMenu.Visible == true)
                panelConceptosSubMenu.Visible = false;
            if (panelMaquilaSubMenu.Visible == true)
                panelMaquilaSubMenu.Visible = false;
            if (panelBrokersSubMenu.Visible == true)
                panelBrokersSubMenu.Visible = false;
            if (panelSociosSubMenu.Visible == true)
                panelSociosSubMenu.Visible = false;
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
            abrirHijoForm(new VISTAS.Clientes(user));
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
            abrirHijoForm(new VISTAS.Empresas(user));
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
            abrirHijoForm(new VISTAS.Conceptos(user));
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

        #region "MAQUILA"
        private void btnMaquila_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelMaquilaSubMenu);
        }

        private void btnNuevaMaquila_Click(object sender, EventArgs e)
        {
            abrirHijoForm(new VISTAS.Maquilas(user));
            //
            OcultarSubMenu();
        }


        #endregion

        #region "BROKERS"
        private void btnBroker_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelBrokersSubMenu);
        }
        private void BTN_NUEVO_BROKER_Click(object sender, EventArgs e)
        {
            abrirHijoForm(new VISTAS.Broker(user));
            //
            OcultarSubMenu();
        }

        #endregion

        #region "SOCIOS"
        private void btnSocios_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSociosSubMenu);
        }
        private void BTN_NUEVO_SOCIO_Click(object sender, EventArgs e)
        {
            abrirHijoForm(new VISTAS.Socios(user));
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

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void panelFormHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMovConcentrado_Click(object sender, EventArgs e)
        {
            abrirHijoForm(new VISTAS.frm_MovimientoConcentrado(user));
            //
            OcultarSubMenu();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSalir.PerformClick();
        }
    }
}
