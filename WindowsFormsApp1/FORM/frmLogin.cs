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
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp1.FORM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string password;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // ACTIVAMOS LAS TECLAS DE FUNCIONES
            this.Text = "Login";    // CAMBIAMOS EL TITULO AL FORM

            // picAPP.Image = Image.FromFile(cnn.rutaImagen);  // llama la imagen que esta indicada en la clase cnn
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // AQUI PREGUNTA SI PRESIONASTE LA TECLA ESC
            { 
                Application.Exit();   // AQUI CIERRA LA APLICACION COMPLETA
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter) 
            { 
                e.Handled = true; 
                if (txtUsuario.Text.Trim() != string.Empty) //Pregunta si el textbox es diferente de vacio
                {
                    txtPassword.Focus(); // Mueve cursor hacia el siguiente textbox
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty) //Pregunta si el textbox es diferente de vacio
            {
                BuscarUsuario(txtUsuario.Text);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtPassword.Text.Trim() != string.Empty) //Pregunta si el textbox es diferente de vacio
                {
                    btnEntrar.Focus(); // Mueve cursor hacia el siguiente textbox
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != string.Empty) //Pregunta si el textbox es diferente de vacio
            {
                btnEntrar.PerformClick(); // aqui ejecutara el evento del boton btnEntrar
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty) //Pregunta si el textbox es diferente de vacio
            {
                if (txtPassword.Text.Trim() != string.Empty) //Pregunta si el textbox es diferente de vacio
                {
                    if (txtPassword.Text.Trim() == password) //Pregunta si el textbox es igual al valor del archivo
                    {
                        this.Hide(); // el login estar invisible o escondido para el usuario

                        frmMenu frm = new frmMenu();
                        frm.ShowDialog();

                        txtPassword.Clear();
                        txtUsuario.Clear();
                        password = string.Empty;

                        this.Show();  // muestra el login nuevamente cuando se cierra el menu
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta", "miAPP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Clave incorrecta", "miAPP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto", "miAPP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();  //  aqui cierra la aplicacion
        }

        // ------------------------------------------------------

        private void BuscarUsuario(string _usuario)
        {
            password = "";

            cnn.miUsuario = "";
            cnn.miNombre = "";
            cnn.miApellido = "";

            // vamos a validar que el archivo solicitado exista
            if (!File.Exists(cnn.rutaArchivo)) 
            {
                MessageBox.Show("No se encontro el archivo de usuario", "miAPP", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // creamos un contenedor (UN ARREGLO)
            string[] contenedor = File.ReadAllLines(cnn.rutaArchivo);

            foreach (string _linea in contenedor) 
            { 
                // vamos a preguntar que si la primera linea esta vacia
                if (string.IsNullOrEmpty(_linea)) continue;

                string[] datos = _linea.Split('|');

                if (datos.Length >= 5)
                {
                    string usuarioArchivo = datos[0].Trim(); // aqui tomamos el usuario

                    if (string.Equals(usuarioArchivo, _usuario, StringComparison.OrdinalIgnoreCase))
                    {
                        string usuarioActivo = datos[2].Trim();

                        if (string.Equals(usuarioActivo, "Inactivo", StringComparison.OrdinalIgnoreCase))
                        {
                            password = "Inactivo";
                        }
                        else
                        {
                            password = datos[1].Trim(); // tomamos el password del archivo

                            cnn.miUsuario = _usuario;  // asigna el usuario del textbox
                            cnn.miNombre = datos[3].Trim(); // asigna el nombre que viene del archivo
                            cnn.miApellido = datos[4].Trim(); // asigna el apellido que viene del archivo
                        }

                        break;
                    }
                }
            }

        }
    }
}
