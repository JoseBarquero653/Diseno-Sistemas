namespace Proyecto_Final.Admin
{
    partial class MenuAdmin
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
            this.btn_aprobador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aprobador
            // 
            this.btn_aprobador.Location = new System.Drawing.Point(69, 116);
            this.btn_aprobador.Name = "btn_aprobador";
            this.btn_aprobador.Size = new System.Drawing.Size(79, 54);
            this.btn_aprobador.TabIndex = 0;
            this.btn_aprobador.Text = "Crear Aprobador";
            this.btn_aprobador.UseVisualStyleBackColor = true;
            this.btn_aprobador.Click += new System.EventHandler(this.btn_aprobador_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aprobador);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_aprobador;
    }
}