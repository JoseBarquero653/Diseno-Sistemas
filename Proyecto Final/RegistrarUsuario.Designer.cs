﻿namespace Proyecto_Final
{
    partial class RegistrarUsuario
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(574, 353);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(259, 114);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(179, 23);
            this.txt_correo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Correo electronico";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(259, 197);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(179, 23);
            this.txt_password.TabIndex = 28;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(259, 154);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(179, 23);
            this.txt_usuario.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre de usuario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(259, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(179, 23);
            this.txt_nombre.TabIndex = 24;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(259, 73);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(179, 23);
            this.txt_apellido.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellido";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(298, 246);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(111, 23);
            this.btn_registrar.TabIndex = 19;
            this.btn_registrar.Text = "Crear Usuario";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarUsuario";
            this.Text = "Crear Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salir;
        private TextBox txt_correo;
        private Label label7;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private Label label6;
        private Label label5;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Label label2;
        private Button btn_registrar;
        private Label label1;
    }
}