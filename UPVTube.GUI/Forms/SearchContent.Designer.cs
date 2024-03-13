using System;
using System.Windows.Forms;

namespace UPVTube.GUI.Forms
{
    partial class SearchContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchContent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPublic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_visualization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_find = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkAutorizar = new System.Windows.Forms.CheckBox();
            this.currentUser_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.title,
            this.nickname,
            this.description,
            this.isPublic,
            this.uploadDate,
            this.subjects,
            this.last_visualization});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ds_id";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // title
            // 
            this.title.DataPropertyName = "ds_title";
            this.title.HeaderText = "Titulo";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 125;
            // 
            // nickname
            // 
            this.nickname.DataPropertyName = "ds_nickname";
            this.nickname.HeaderText = "Nickname";
            this.nickname.MinimumWidth = 6;
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.Width = 125;
            // 
            // description
            // 
            this.description.DataPropertyName = "ds_description";
            this.description.HeaderText = "Descripción";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 125;
            // 
            // isPublic
            // 
            this.isPublic.DataPropertyName = "ds_isPublic";
            this.isPublic.HeaderText = "Público";
            this.isPublic.MinimumWidth = 6;
            this.isPublic.Name = "isPublic";
            this.isPublic.ReadOnly = true;
            this.isPublic.Width = 125;
            // 
            // uploadDate
            // 
            this.uploadDate.DataPropertyName = "ds_uploadDate";
            this.uploadDate.HeaderText = "Fecha Subida";
            this.uploadDate.MinimumWidth = 6;
            this.uploadDate.Name = "uploadDate";
            this.uploadDate.ReadOnly = true;
            this.uploadDate.Width = 125;
            // 
            // subjects
            // 
            this.subjects.DataPropertyName = "ds_subjects";
            this.subjects.HeaderText = "Asignaturas";
            this.subjects.MinimumWidth = 6;
            this.subjects.Name = "subjects";
            this.subjects.ReadOnly = true;
            this.subjects.Width = 125;
            // 
            // last_visualization
            // 
            this.last_visualization.DataPropertyName = "ds_last_visualization";
            this.last_visualization.HeaderText = "Última Visualización";
            this.last_visualization.MinimumWidth = 6;
            this.last_visualization.Name = "last_visualization";
            this.last_visualization.ReadOnly = true;
            this.last_visualization.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Date:";
            // 
            // datePickerInitial
            // 
            this.datePickerInitial.CustomFormat = "  ";
            this.datePickerInitial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerInitial.Location = new System.Drawing.Point(121, 91);
            this.datePickerInitial.Name = "datePickerInitial";
            this.datePickerInitial.Size = new System.Drawing.Size(256, 22);
            this.datePickerInitial.TabIndex = 2;
            this.datePickerInitial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datePickerInitial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "  ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(497, 93);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nickname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Palabra Clave:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(766, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 8;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(497, 134);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubject.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Asignatura:";
            // 
            // button_find
            // 
            this.button_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_find.Location = new System.Drawing.Point(859, 34);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(160, 35);
            this.button_find.TabIndex = 11;
            this.button_find.Text = "Buscar contenido";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(256, 37);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(186, 33);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Cerrar sesión";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(656, 35);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(186, 33);
            this.uploadButton.TabIndex = 13;
            this.uploadButton.Text = "Subir contenido";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pendiente de autorizar:";
            // 
            // checkAutorizar
            // 
            this.checkAutorizar.AutoSize = true;
            this.checkAutorizar.Location = new System.Drawing.Point(803, 137);
            this.checkAutorizar.Name = "checkAutorizar";
            this.checkAutorizar.Size = new System.Drawing.Size(18, 17);
            this.checkAutorizar.TabIndex = 17;
            this.checkAutorizar.UseVisualStyleBackColor = true;
            // 
            // currentUser_label
            // 
            this.currentUser_label.AutoSize = true;
            this.currentUser_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser_label.Location = new System.Drawing.Point(83, 37);
            this.currentUser_label.Name = "currentUser_label";
            this.currentUser_label.Size = new System.Drawing.Size(167, 32);
            this.currentUser_label.TabIndex = 18;
            this.currentUser_label.Text = "CurrentUser";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UPVTube.GUI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(39, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // SearchContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentUser_label);
            this.Controls.Add(this.checkAutorizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerInitial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchContent";
            this.Text = "Busqueda - UPVTube";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerInitial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Button logoutButton;
        private Button uploadButton;
        private Label label6;
        private CheckBox checkAutorizar;
        private Label currentUser_label;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn nickname;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn isPublic;
        private DataGridViewTextBoxColumn uploadDate;
        private DataGridViewTextBoxColumn subjects;
        private DataGridViewTextBoxColumn last_visualization;
        private PictureBox pictureBox1;
    }
}