using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private Button botonActivoMenu = null; // para saber que boton esta activo
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // ACTIVAMOS LAS TECLAS DE FUNCIONES
            this.Text = "Menu";    // CAMBIAMOS EL TITULO AL FORM

            lblNombre.Text = cnn.miNombre;
            lblUsuario.Text = cnn.miApellido;

            // imagen---------

            if (File.Exists(cnn.rutaImagen))
            {
                picAPP.Image = Image.FromFile(cnn.rutaImagen);
                picAPP.SizeMode = PictureBoxSizeMode.StretchImage; // Para que la imagen se ajuste al cuadro
            }

            // imagen---------

            // asegura que el submenu pertenece al formulario base
            panelSubMenu.Dock = DockStyle.None;

            if (this.Controls.Contains(panelSubMenu) == false)
            {
                Control panelPadreAnterior = panelSubMenu.Parent;  // obtiene el panel padre anterior del submenu
                if (panelPadreAnterior != null)
                {
                    panelPadreAnterior.Controls.Remove(panelSubMenu);
                }
                this.Controls.Add(panelSubMenu);
            }

            panelSubMenu.Visible = false; // AQUI ESCONDE EL SUB MENU

        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e) 
        {

            if (e.KeyCode == Keys.Escape)  // AQUI PREGUNTA SI PRESIONASTE LA TECLA ESC
            {
                Application.Exit();   // AQUI CIERRA LA APLICACION COMPLETA
            }

        }

        // ---------------------------------------------------------
        // METODOS
        // ---------------------------------------------------------
        private void Mover_y_Mostrar_SubMenu(Button botonPadre)
        {
            // buscamos en le contenedor izquierdo el boton 
            Control panelIzquierdo = botonPadre.Parent;

            int posicionX = panelIzquierdo.Width;
            int posicionY = panelIzquierdo.Location.Y + botonPadre.Location.Y;

            panelSubMenu.Location = new Point(posicionX, posicionY);
            panelSubMenu.BringToFront();
            panelSubMenu.Visible = true;
        }

        private void ConfigurarBotonesInternos(string nombreBoton)
        {
            if (nombreBoton == "btnUNO")
            {
                btnOPUNO.Text = "formulario uno";
                btnOPDOS.Text = "formulario dos";
                btnOPTRES.Text = "formulario tres";
            }
            else if (nombreBoton == "btnDOS")
            {
                btnOPUNO.Text = "consulta uno";
                btnOPDOS.Text = "consulta dos";
                btnOPTRES.Text = "consulta tres";
            }
            else if (nombreBoton == "btnTRES")
            {
                btnOPUNO.Text = "reporte uno";
                btnOPDOS.Text = "reporte dos";
                btnOPTRES.Text = "reporte tres";
            }
            else if (nombreBoton == "btnCUATRO")
            {
                btnOPUNO.Text = "Esquema uno";
                btnOPDOS.Text = "Esquema cuatro dos";
                btnOPTRES.Text = "Esquema cuatro tres";
            }
            else if (nombreBoton == "btnCINCO")
            {
                btnOPUNO.Text = "Base de datos uno";
                btnOPDOS.Text = "Base de datos dos";
                btnOPTRES.Text = "Base de datos tres";
            }
        }

        private void btnUNO_Click_1(object sender, EventArgs e)
        {
            // si ya esta abierto el submenu lo ocultamos
            if (panelSubMenu.Visible && botonActivoMenu == btnUNO)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnUNO;
            ConfigurarBotonesInternos("btnUNO");
            Mover_y_Mostrar_SubMenu(btnUNO);
        }

        private void btnDOS_Click(object sender, EventArgs e)
        {
            // si ya esta abierto el submenu lo ocultamos
            if (panelSubMenu.Visible && botonActivoMenu == btnDOS)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnDOS;
            ConfigurarBotonesInternos("btnDOS");
            Mover_y_Mostrar_SubMenu(btnDOS);
        }

        private void btnTRES_Click(object sender, EventArgs e)
        {
            // si ya esta abierto el submenu lo ocultamos
            if (panelSubMenu.Visible && botonActivoMenu == btnTRES)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnTRES;
            ConfigurarBotonesInternos("btnTRES");
            Mover_y_Mostrar_SubMenu(btnTRES);
        }

        private void btnCUATRO_Click(object sender, EventArgs e)
        {
            if (panelSubMenu.Visible && botonActivoMenu == btnCUATRO)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnCUATRO;
            ConfigurarBotonesInternos("btnCUATRO");
            Mover_y_Mostrar_SubMenu(btnCUATRO);
        }

        private void btnCINCO_Click(object sender, EventArgs e)
        {
            if (panelSubMenu.Visible && botonActivoMenu == btnCINCO)
            {
                panelSubMenu.Visible = false;
                botonActivoMenu = null;
                return;
            }

            botonActivoMenu = btnCINCO;
            ConfigurarBotonesInternos("btnCINCO");
            Mover_y_Mostrar_SubMenu(btnCINCO);
        }

        private void btnOPUNO_Click(object sender, EventArgs e)
        {
            if (botonActivoMenu == null) return;

            if (botonActivoMenu == btnUNO)
            {
                MessageBox.Show("Abriendo Formulario");
            }
            else if (botonActivoMenu == btnDOS)
            {
                MessageBox.Show("Abriendo Formulario");
            }
            else if (botonActivoMenu == btnTRES)
            {
                MessageBox.Show("Abriendo Formulario");
            }
        }


    }
}
