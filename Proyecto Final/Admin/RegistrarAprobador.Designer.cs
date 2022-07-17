namespace Proyecto_Final.Admin
{
    partial class RegistrarAprobador
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
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.rb_jefe = new System.Windows.Forms.RadioButton();
            this.rb_tipo3 = new System.Windows.Forms.RadioButton();
            this.rb_tipo2 = new System.Windows.Forms.RadioButton();
            this.rb_tipo1 = new System.Windows.Forms.RadioButton();
            this.gb_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(407, 423);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(111, 23);
            this.btn_salir.TabIndex = 45;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(285, 128);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(179, 23);
            this.txt_correo.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Correo electronico";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(285, 206);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(179, 23);
            this.txt_password.TabIndex = 42;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(285, 168);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(179, 23);
            this.txt_usuario.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nombre de usuario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(285, 42);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(179, 23);
            this.txt_nombre.TabIndex = 38;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(285, 84);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(179, 23);
            this.txt_apellido.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Apellido";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(237, 423);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(111, 23);
            this.btn_registrar.TabIndex = 33;
            this.btn_registrar.Text = "Crear Usuario";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.rb_jefe);
            this.gb_tipo.Controls.Add(this.rb_tipo3);
            this.gb_tipo.Controls.Add(this.rb_tipo2);
            this.gb_tipo.Controls.Add(this.rb_tipo1);
            this.gb_tipo.Location = new System.Drawing.Point(285, 252);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(200, 135);
            this.gb_tipo.TabIndex = 47;
            this.gb_tipo.TabStop = false;
            this.gb_tipo.Text = "Tipo de aprobador";
            // 
            // rb_jefe
            // 
            this.rb_jefe.AutoSize = true;
            this.rb_jefe.Checked = true;
            this.rb_jefe.Location = new System.Drawing.Point(6, 22);
            this.rb_jefe.Name = "rb_jefe";
            this.rb_jefe.Size = new System.Drawing.Size(105, 19);
            this.rb_jefe.TabIndex = 3;
            this.rb_jefe.TabStop = true;
            this.rb_jefe.Text = "Aprobador Jefe";
            this.rb_jefe.UseVisualStyleBackColor = true;
            // 
            // rb_tipo3
            // 
            this.rb_tipo3.AutoSize = true;
            this.rb_tipo3.Location = new System.Drawing.Point(6, 95);
            this.rb_tipo3.Name = "rb_tipo3";
            this.rb_tipo3.Size = new System.Drawing.Size(117, 19);
            this.rb_tipo3.TabIndex = 2;
            this.rb_tipo3.TabStop = true;
            this.rb_tipo3.Text = "Aprobador Tipo 3";
            this.rb_tipo3.UseVisualStyleBackColor = true;
            // 
            // rb_tipo2
            // 
            this.rb_tipo2.AutoSize = true;
            this.rb_tipo2.Location = new System.Drawing.Point(6, 70);
            this.rb_tipo2.Name = "rb_tipo2";
            this.rb_tipo2.Size = new System.Drawing.Size(121, 19);
            this.rb_tipo2.TabIndex = 1;
            this.rb_tipo2.TabStop = true;
            this.rb_tipo2.Text = "Aprobardor Tipo 2";
            this.rb_tipo2.UseVisualStyleBackColor = true;
            // 
            // rb_tipo1
            // 
            this.rb_tipo1.AutoSize = true;
            this.rb_tipo1.Location = new System.Drawing.Point(6, 45);
            this.rb_tipo1.Name = "rb_tipo1";
            this.rb_tipo1.Size = new System.Drawing.Size(117, 19);
            this.rb_tipo1.TabIndex = 0;
            this.rb_tipo1.TabStop = true;
            this.rb_tipo1.Text = "Aprobador Tipo 1";
            this.rb_tipo1.UseVisualStyleBackColor = true;
            // 
            // RegistrarAprobador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.gb_tipo);
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
            this.Name = "RegistrarAprobador";
            this.Text = "Registrar Aprobador";
            this.Load += new System.EventHandler(this.RegistrarAprobador_Load);
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
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
        private GroupBox gb_tipo;
        private RadioButton rb_jefe;
        private RadioButton rb_tipo3;
        private RadioButton rb_tipo2;
        private RadioButton rb_tipo1;
    }
}