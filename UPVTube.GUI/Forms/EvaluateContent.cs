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
    public partial class EvaluateContent : Form
    {
        IUPVTubeService service;
        Content content;
        public EvaluateContent(IUPVTubeService service, Content content, Member member)
        {
            InitializeComponent();
            this.service = service;
            this.content = content;
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            service.contentEvaluationUpdate(this.content, true);
            DialogResult answer = MessageBox.Show(this, // Owner
                    "Se enviará un correo con la corrección pertinente", // Message
                    "Correo", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Information); // Icon
            this.Close();
        }

        private void Decline_button_Click(object sender, EventArgs e)
        {
            service.contentEvaluationUpdate(this.content, false);

            if (this.comment_textBox.Text == "")
            {
                DialogResult alert = MessageBox.Show(this, // Owner
                   "Es obligatorio especificar el motivo del rechazo", // Message
                   "Motivo del rechazo", // Title
                   MessageBoxButtons.OK, // Buttons included
                   MessageBoxIcon.Information); // Icon
            } else
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                   "Se enviará un correo con la corrección pertinente", // Message
                   "Correo", // Title
                   MessageBoxButtons.OK, // Buttons included
                   MessageBoxIcon.Information); // Icon
                this.Close();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
