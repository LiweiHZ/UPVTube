using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTube.GUI.Forms
{
    public partial class SignUp : Form
    {

        private IUPVTubeService service;
        public SignUp(IUPVTubeService serviceIn)
        {
            InitializeComponent();
            service = serviceIn;
            this.FormClosing += FormClose;
        }
        private void FormClose(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["UPVTubeApp"].Show();
        }
        private void Registrarme_Click(object sender, EventArgs e)
        {
            bool error = false;

            string correo = correoField.Text;
            string nombre = nombreField.Text;
            string nick = nickField.Text;
            string password = passwordField.Text;
            if (correo == "" || nombre == "" || nick == "" || password == "") {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Debes completar todos los campos (correo, nombre, nickname y password)", // Message
                "Error de registro", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Information); // Icon
            } 
            else
            {
                Member mmm = new Member(correo, nombre, DateTime.Now, nick, password);
                try { 
                    service.SignUp(mmm);
                    DialogResult answer = MessageBox.Show(this, // Owner
                    "Usuario correctamente registrado", // Message
                    "Información", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Information); // Icon
                }
                catch (Exception eee) {
                    DialogResult answer = MessageBox.Show(this, // Owner
                    eee.Message, // Message
                    "Error de registro", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Information); // Icon
                    error = true;
                }

                if (!error)
                {
                    Application.OpenForms["UPVTubeApp"].Show();
                    this.Close();
                }
            }
            

            
        }

        private void Iniciar_sesion_Click(object sender, EventArgs e)
        {
            Application.OpenForms["UPVTubeApp"].Show();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

    }
}
