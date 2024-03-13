namespace UPVTube.GUI.Forms
{
    partial class Upload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upload));
            this.uri_fld = new System.Windows.Forms.TextBox();
            this.upload_btn = new System.Windows.Forms.Button();
            this.uri_lb = new System.Windows.Forms.Label();
            this.subject_list = new System.Windows.Forms.CheckedListBox();
            this.title_fld = new System.Windows.Forms.TextBox();
            this.title_lb = new System.Windows.Forms.Label();
            this.subject_lb = new System.Windows.Forms.Label();
            this.description_lb = new System.Windows.Forms.Label();
            this.description_fld = new System.Windows.Forms.TextBox();
            this.public_ckb = new System.Windows.Forms.CheckBox();
            this.public_lb = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.accept_btn = new System.Windows.Forms.Button();
            this.upvTubeDBDataSet1 = new UPVTubePersistenceTests.UPVTubeDBDataSet();
            this.Evaluar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upvTubeDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // uri_fld
            // 
            this.uri_fld.Location = new System.Drawing.Point(53, 155);
            this.uri_fld.Name = "uri_fld";
            this.uri_fld.Size = new System.Drawing.Size(383, 22);
            this.uri_fld.TabIndex = 0;
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(442, 155);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(75, 23);
            this.upload_btn.TabIndex = 1;
            this.upload_btn.Text = "Examinar";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // uri_lb
            // 
            this.uri_lb.AutoSize = true;
            this.uri_lb.Location = new System.Drawing.Point(50, 136);
            this.uri_lb.Name = "uri_lb";
            this.uri_lb.Size = new System.Drawing.Size(92, 16);
            this.uri_lb.TabIndex = 2;
            this.uri_lb.Text = "URI del video:";
            // 
            // subject_list
            // 
            this.subject_list.FormattingEnabled = true;
            this.subject_list.Location = new System.Drawing.Point(53, 208);
            this.subject_list.Name = "subject_list";
            this.subject_list.ScrollAlwaysVisible = true;
            this.subject_list.Size = new System.Drawing.Size(383, 89);
            this.subject_list.TabIndex = 3;
            // 
            // title_fld
            // 
            this.title_fld.Location = new System.Drawing.Point(53, 100);
            this.title_fld.Name = "title_fld";
            this.title_fld.Size = new System.Drawing.Size(464, 22);
            this.title_fld.TabIndex = 4;
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Location = new System.Drawing.Point(50, 81);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(40, 16);
            this.title_lb.TabIndex = 5;
            this.title_lb.Text = "Titulo";
            // 
            // subject_lb
            // 
            this.subject_lb.AutoSize = true;
            this.subject_lb.Location = new System.Drawing.Point(50, 189);
            this.subject_lb.Name = "subject_lb";
            this.subject_lb.Size = new System.Drawing.Size(81, 16);
            this.subject_lb.TabIndex = 6;
            this.subject_lb.Text = "Asignaturas:";
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Location = new System.Drawing.Point(50, 307);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(82, 16);
            this.description_lb.TabIndex = 7;
            this.description_lb.Text = "Descripción:";
            // 
            // description_fld
            // 
            this.description_fld.Location = new System.Drawing.Point(53, 326);
            this.description_fld.Multiline = true;
            this.description_fld.Name = "description_fld";
            this.description_fld.Size = new System.Drawing.Size(464, 93);
            this.description_fld.TabIndex = 8;
            // 
            // public_ckb
            // 
            this.public_ckb.AutoSize = true;
            this.public_ckb.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.public_ckb.Location = new System.Drawing.Point(198, 438);
            this.public_ckb.Name = "public_ckb";
            this.public_ckb.Size = new System.Drawing.Size(74, 20);
            this.public_ckb.TabIndex = 9;
            this.public_ckb.Text = "Publico";
            this.public_ckb.UseVisualStyleBackColor = true;
            // 
            // public_lb
            // 
            this.public_lb.AutoSize = true;
            this.public_lb.Location = new System.Drawing.Point(50, 439);
            this.public_lb.Name = "public_lb";
            this.public_lb.Size = new System.Drawing.Size(132, 16);
            this.public_lb.TabIndex = 10;
            this.public_lb.Text = "Visibilidad del video:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(442, 492);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancelar";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // accept_btn
            // 
            this.accept_btn.Location = new System.Drawing.Point(361, 492);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(75, 23);
            this.accept_btn.TabIndex = 12;
            this.accept_btn.Text = "Aceptar";
            this.accept_btn.UseVisualStyleBackColor = true;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // upvTubeDBDataSet1
            // 
            this.upvTubeDBDataSet1.DataSetName = "UPVTubeDBDataSet";
            this.upvTubeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Evaluar_button
            // 
            this.Evaluar_button.Location = new System.Drawing.Point(53, 492);
            this.Evaluar_button.Name = "Evaluar_button";
            this.Evaluar_button.Size = new System.Drawing.Size(113, 23);
            this.Evaluar_button.TabIndex = 13;
            this.Evaluar_button.Text = "Autorización";
            this.Evaluar_button.UseVisualStyleBackColor = true;
            this.Evaluar_button.Click += new System.EventHandler(this.Evaluar_button_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 562);
            this.Controls.Add(this.Evaluar_button);
            this.Controls.Add(this.accept_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.public_lb);
            this.Controls.Add(this.public_ckb);
            this.Controls.Add(this.description_fld);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.subject_lb);
            this.Controls.Add(this.title_lb);
            this.Controls.Add(this.title_fld);
            this.Controls.Add(this.subject_list);
            this.Controls.Add(this.uri_lb);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.uri_fld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Upload";
            this.Text = "Content - UPVTube";
            this.Load += new System.EventHandler(this.Upload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upvTubeDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uri_fld;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Label uri_lb;
        private System.Windows.Forms.CheckedListBox subject_list;
        private System.Windows.Forms.TextBox title_fld;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Label subject_lb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.TextBox description_fld;
        private System.Windows.Forms.CheckBox public_ckb;
        private System.Windows.Forms.Label public_lb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button accept_btn;
        private UPVTubePersistenceTests.UPVTubeDBDataSet upvTubeDBDataSet1;
        private System.Windows.Forms.Button Evaluar_button;
    }
}