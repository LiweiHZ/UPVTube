using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;

namespace UPVTube.GUI.Forms
{
    public partial class SearchContent : Form
    {
        private IUPVTubeService service;
        private Member loggedMember;
        private Boolean cb = false;
        public SearchContent(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            loggedMember = service.getLogged(); ;
            LoadData();
            this.FormClosing += FormClose;

        }
        private void FormClose(object sender, FormClosingEventArgs e)
        {
            if (!cb)
            {
                cb = false;
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void LoadData()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ICollection<Member> allMembers = service.AllMembers();
            ICollection<Subject> subjects = service.GetSubjects();
            
            comboBoxSubject.Items.Clear();
            comboBoxUser.Items.Clear();
            allMembers.Add(new Member { Nick = "" });
            subjects.Add(new Subject { Name = "" });
            comboBoxSubject.DataSource = subjects;
            comboBoxSubject.DisplayMember = "Name";
            comboBoxUser.DataSource = allMembers;
            comboBoxUser.DisplayMember = "Nick";
            comboBoxSubject.SelectedIndex = -1;
            comboBoxSubject.ResetText();
            comboBoxUser.SelectedIndex = -1;
            comboBoxUser.ResetText();

            currentUser_label.Text = loggedMember.Nick;

            if (!loggedMember.IsTeacher()) { 
                checkAutorizar.Enabled = false;
                checkAutorizar.Visible = false;
                label6.Enabled = false;
                label6.Visible = false;
                if (!loggedMember.IsStudent()) { 
                    uploadButton.Enabled = false;
                    uploadButton.Visible = false;
                }
            }
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void reload()
        {
            button_find_Click(null, null);
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            Subject selectedSubject = null;
            Member selectedMember = null;
            String keyword = null;
            if (comboBoxSubject.SelectedIndex != -1)
            {
                selectedSubject = (Subject)comboBoxSubject.SelectedItem;
                if (selectedSubject.Name == "") { selectedSubject = null; }
            }
            if (comboBoxUser.SelectedIndex != -1)
            {
                selectedMember = (Member)comboBoxUser.SelectedItem;
                if (selectedMember.Nick == "") { selectedMember = null; }
            }

            DateTime dateTimeInitial = datePickerInitial.Value;
            if (datePickerInitial.Format == System.Windows.Forms.DateTimePickerFormat.Custom)
                dateTimeInitial = DateTime.MinValue;

            
            DateTime dateTimeFinal = dateTimePicker1.Value;
            if (dateTimePicker1.Format == System.Windows.Forms.DateTimePickerFormat.Custom)
                dateTimeFinal = DateTime.MaxValue;

            if (textBox1.Text != "")
            {
                keyword = textBox1.Text;
            }
            
            
            if (dateTimeInitial<dateTimeFinal)
            {
                IEnumerable<Content> contents = service.findContent(dateTimeInitial, dateTimeFinal, selectedMember, keyword, selectedSubject, checkAutorizar.Checked);

                BindingList<object> bindinglist = new BindingList<object>();
                foreach (var c in contents)
                {
                    string subs = "";
                    foreach (Subject ss in c.Subjects)
                    {
                        subs += (" " + ss.Name);
                    }
                    string lastv = "";
                    Visualization vis = service.getLastVisualizations(service.getLogged(), c);
                    if (vis != null)
                        lastv = vis.VisualizationDate.ToString();
                    bindinglist.Add(new
                    {
                        ds_id = c.Id,
                        ds_title = c.Title,
                        ds_description = c.Description,
                        ds_nickname = c.Owner.Nick,
                        ds_isPublic = c.IsPublic,
                        ds_uploadDate = c.UploadDate,
                        ds_subjects = subs,
                        ds_last_visualization = lastv
                    });
                }
                bindingSource1.DataSource = bindinglist;
            }
            else {
                DialogResult answer = MessageBox.Show(this, // Owner
                    "La fecha inicial debe ser anterior a la final", // Message
                    "Error", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Error); // Icon
            }
        }


        private void datePickerInitial_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerInitial.CustomFormat == "  ") {
                datePickerInitial.Format = DateTimePickerFormat.Long;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.CustomFormat == "  ")
            {
                dateTimePicker1.Format = DateTimePickerFormat.Long;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            cb = true;
            UPVTubeApp loginWindow = new UPVTubeApp(service);
            service.Logout();
            loginWindow.Show();
            this.Close();

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            Upload uploadWindow = new Upload(service, this);
            uploadWindow.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Upload uploadWindow = new Upload(service, service.getContentbyId(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), this);
            uploadWindow.Show();
        }

    }
}