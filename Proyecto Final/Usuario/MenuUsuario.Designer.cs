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
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 569);
            this.Controls.Add(this.btn_solicitud);
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_solicitud;
    }
}