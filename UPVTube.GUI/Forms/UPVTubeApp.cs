using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.GUI.Forms;
using UPVTube.Services;

namespace UPVTube.GUI
{
    public partial class UPVTubeApp : Form
    {
        private IUPVTubeService service;
        private Member user;
        public UPVTubeApp(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            user = null;
            passwordField.PasswordChar = '*';
            this.FormClosing += FormClose;
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }



        private void Iniciar_sesion_Click(object sender, EventArgs e)
        {
            bool error = false;

            user = null;
            String username, user_password;
            username = correoField.Text;
            user_password = passwordField.Text;
            if (username == "" || user_password == "")
            {
                    DialogResult answer = MessageBox.Show(this, // Owner
                    "Introduce tu correo electrónico/nickname y password", // Message
                    "Information", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Information); // Icon
            }
            else
            {
                try { user = service.Login(username, user_password); }
                catch(Exception eee)
                {
                    DialogResult answer = MessageBox.Show(this, // Owner
                    eee.Message, // Message
                    "Error", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Information); // Icon
                    error = true;
                    user = null;
                }
                finally { 
                    if (!error)
                    {
                        SearchContent logged = new SearchContent(service);
                        logged.Show();
                        this.Hide();
                    }
                }
            } 
        }

        private void Registrarme_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp(service);
            signup.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.DBInitialization();
            DialogResult answer = MessageBox.Show(this, // Owner
            "Data base Correctly Initialized ", // Message
            "Information", // Title
            MessageBoxButtons.OK, // Buttons included
            MessageBoxIcon.Information); // Icon
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            SearchContent content = new SearchContent(service);
            content.Show();
            this.Hide();
        }
    }
}
