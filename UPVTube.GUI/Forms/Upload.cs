using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTube.GUI.Forms
{
    public partial class Upload : Form
    {
        private IUPVTubeService service;
        private Member member;
        private Content content;
        private SearchContent sc;
        public Upload(IUPVTubeService service ,SearchContent sscc)
        {
            InitializeComponent();
            this.service = service;
            this.member = service.getLogged() ;
            ICollection<Subject> subjects = service.GetSubjects();
            subject_list.Items.Clear();
            subject_list.DataSource = subjects;
            subject_list.DisplayMember = "FullName";
            subject_list.SelectedIndex = -1;
            Evaluar_button.Enabled = false;
            Evaluar_button.Visible = false;
            sc = sscc;
        }

        public Upload(IUPVTubeService service, Content content, SearchContent sc)
        {
            InitializeComponent();
            this.sc = sc;
            this.service = service;
            this.member = service.getLogged();
            this.content = content;
            title_fld.Text = content.Title;
            title_fld.Enabled = false;
            uri_fld.Text = content.ContentURI;
            uri_fld.Enabled = false;
            description_fld.Text = content.Description;
            description_fld.Enabled = false;
            ICollection<Subject> subjects = content.Subjects;
            subject_list.Items.Clear();
            subject_list.DataSource = subjects;
            subject_list.DisplayMember = "FullName";
            for (int i = 0; i < subject_list.Items.Count; i++)
            {
                subject_list.SetItemChecked(i, true);
            }
            subject_list.SelectedIndex = -1;
            subject_list.Enabled = false;
            public_ckb.Checked = content.IsPublic;
            public_ckb.Enabled = false;
            upload_btn.Visible = false;
            accept_btn.Visible = false;
            cancel_btn.Text = "Cerrar";
            Evaluar_button.Visible = member.IsTeacher() && content.Authorized == Authorized.Pending;
            member.Visualizations.Add(new Visualization(DateTime.Now, content, member));
            service.Commit();
        }

        private void Upload_Load(object sender, EventArgs e)
        {
            sc.reload();
        }


        private void accept_btn_Click(object sender, EventArgs e)
        {
            Content upload;
            String title, uri, description;
            Boolean is_public;
            Boolean uploadeable = true;
            title = title_fld.Text;
            uri = uri_fld.Text;
            description = description_fld.Text;
            is_public = public_ckb.Checked;
            upload = new Content(uri, description, is_public, title, DateTime.Now, member);
            int solo3 = 0;
            if (subject_list.CheckedItems != null)
            {
                foreach (Subject subject in subject_list.CheckedItems)
                {
                    
                    solo3++;
                    if (solo3 > 3) {
                        DialogResult answer = MessageBox.Show(this, // Owner
                        "Maximo numero de asignaturas superado", // Message
                        "Error", // Title
                        MessageBoxButtons.OK, // Buttons included
                        MessageBoxIcon.Exclamation); // Icon
                        uploadeable = false;
                        break;
                    } else
                    {
                        upload.Subjects.Add(subject);
                    }
                }
            }

            if (title != "" && uri != "" && description != "" && uploadeable) {

                if (member.IsTeacher())
                {
                    upload.Authorized = Authorized.Yes;
                }
                else { if (member.IsStudent()) { upload.Authorized = Authorized.Pending; } }
                service.contentUpload(upload);

                DialogResult answer = MessageBox.Show(this, // Owner
                "El archivo ha sido subido correctamente", // Message
                "Uploaded", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Information); // Icon
                Upload_Load(null, null);
                Application.OpenForms["SearchContent"].Show();
                this.Close();
            } else if (solo3 <= 3)
            {
                DialogResult answer = MessageBox.Show(this, // Owner
                "Faltan campos que rellenar", // Message
                "Error", // Title
                MessageBoxButtons.OK, // Buttons included
                MessageBoxIcon.Exclamation); // Icon
            }

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(this, // Owner
            "Aqui deberias poder seleccionar un archivo", // Message
            "Selección de archivos", // Title
            MessageBoxButtons.OK, // Buttons included
            MessageBoxIcon.Information); // Icon
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
 
            Application.OpenForms["SearchContent"].Show();
            
            this.Close();
        }

        private void Evaluar_button_Click(object sender, EventArgs e)
        {
            EvaluateContent evaluateContent = new EvaluateContent(service,content,member);
            evaluateContent.ShowDialog();
        }
    }

}
