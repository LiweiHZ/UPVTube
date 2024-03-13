namespace UPVTube.GUI.Forms
{
    partial class EvaluateContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvaluateContent));
            this.comment_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accept_button = new System.Windows.Forms.Button();
            this.Decline_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comment_textBox
            // 
            this.comment_textBox.Location = new System.Drawing.Point(46, 57);
            this.comment_textBox.Multiline = true;
            this.comment_textBox.Name = "comment_textBox";
            this.comment_textBox.Size = new System.Drawing.Size(478, 117);
            this.comment_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comentario de la evaluación";
            // 
            // accept_button
            // 
            this.accept_button.Location = new System.Drawing.Point(274, 205);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(75, 23);
            this.accept_button.TabIndex = 2;
            this.accept_button.Text = "Autorizar";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // Decline_button
            // 
            this.Decline_button.Location = new System.Drawing.Point(355, 205);
            this.Decline_button.Name = "Decline_button";
            this.Decline_button.Size = new System.Drawing.Size(75, 23);
            this.Decline_button.TabIndex = 3;
            this.Decline_button.Text = "Rechazar";
            this.Decline_button.UseVisualStyleBackColor = true;
            this.Decline_button.Click += new System.EventHandler(this.Decline_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(449, 205);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 4;
            this.cancel_button.Text = "Cancelar";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // EvaluateContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 251);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.Decline_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvaluateContent";
            this.Text = "Evaluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comment_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button Decline_button;
        private System.Windows.Forms.Button cancel_button;
    }
}