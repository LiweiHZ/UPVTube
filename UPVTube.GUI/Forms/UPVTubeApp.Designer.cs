using UPVTube.Services;

namespace UPVTube.GUI
{
    public partial class UPVTubeApp
    {

        

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UPVTubeApp));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Iniciar_sesion = new System.Windows.Forms.Button();
            this.Registrarme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.correoField = new System.Windows.Forms.TextBox();
            this.inicializarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Iniciar_sesion
            // 
            resources.ApplyResources(this.Iniciar_sesion, "Iniciar_sesion");
            this.Iniciar_sesion.Name = "Iniciar_sesion";
            this.Iniciar_sesion.UseVisualStyleBackColor = true;
            this.Iniciar_sesion.Click += new System.EventHandler(this.Iniciar_sesion_Click);
            // 
            // Registrarme
            // 
            this.Registrarme.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.Registrarme, "Registrarme");
            this.Registrarme.Name = "Registrarme";
            this.Registrarme.UseVisualStyleBackColor = false;
            this.Registrarme.Click += new System.EventHandler(this.Registrarme_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.passwordField, "passwordField");
            this.passwordField.Name = "passwordField";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // correoField
            // 
            this.correoField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.correoField, "correoField");
            this.correoField.Name = "correoField";
            // 
            // inicializarButton
            // 
            resources.ApplyResources(this.inicializarButton, "inicializarButton");
            this.inicializarButton.Name = "inicializarButton";
            this.inicializarButton.UseVisualStyleBackColor = true;
            this.inicializarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UPVTubeApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inicializarButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Iniciar_sesion);
            this.Controls.Add(this.Registrarme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.correoField);
            this.Controls.Add(this.label1);
            this.Name = "UPVTubeApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Iniciar_sesion;
        private System.Windows.Forms.Button Registrarme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox correoField;
        private System.Windows.Forms.Button inicializarButton;
    }
}

