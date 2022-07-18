namespace Proyecto_Final.Usuario
{
    partial class MenuUsuario
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
            this.btn_solicitud = new System.Windows.Forms.Button();
            this.btn_requis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_solicitud
            // 
            this.btn_solicitud.Location = new System.Drawing.Point(12, 82);
            this.btn_solicitud.Name = "btn_solicitud";
            this.btn_solicitud.Size = new System.Drawing.Size(150, 97);
            this.btn_solicitud.TabIndex = 0;
            this.btn_solicitud.Text = "Ingresar Solicitud";
            this.btn_solicitud.UseVisualStyleBackColor = true;
            this.btn_solicitud.Click += new System.EventHandler(this.btn_solicitud_Click);
            // 
            // btn_requis
            // 
            this.btn_requis.Location = new System.Drawing.Point(12, 382);
            this.btn_requis.Name = "btn_requis";
            this.btn_requis.Size = new System.Drawing.Size(150, 97);
            this.btn_requis.TabIndex = 1;
            this.btn_requis.Text = "Ver Requisiciones";
            this.btn_requis.UseVisualStyleBackColor = true;
            this.btn_requis.Click += new System.EventHandler(this.btn_requis_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 569);
            this.Controls.Add(this.btn_requis);
            this.Controls.Add(this.btn_solicitud);
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_solicitud;
        private Button btn_requis;
    }
}