namespace Proyecto_Final.Usuario
{
    partial class VerRequis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_rech = new System.Windows.Forms.RadioButton();
            this.rb_confir = new System.Windows.Forms.RadioButton();
            this.rb_aprob = new System.Windows.Forms.RadioButton();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(764, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_rech);
            this.groupBox1.Controls.Add(this.rb_confir);
            this.groupBox1.Controls.Add(this.rb_aprob);
            this.groupBox1.Location = new System.Drawing.Point(24, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_rech
            // 
            this.rb_rech.AutoSize = true;
            this.rb_rech.Location = new System.Drawing.Point(254, 22);
            this.rb_rech.Name = "rb_rech";
            this.rb_rech.Size = new System.Drawing.Size(86, 19);
            this.rb_rech.TabIndex = 2;
            this.rb_rech.Text = "Rechazadas";
            this.rb_rech.UseVisualStyleBackColor = true;
            this.rb_rech.CheckedChanged += new System.EventHandler(this.rb_rech_CheckedChanged);
            // 
            // rb_confir
            // 
            this.rb_confir.AutoSize = true;
            this.rb_confir.Location = new System.Drawing.Point(143, 22);
            this.rb_confir.Name = "rb_confir";
            this.rb_confir.Size = new System.Drawing.Size(93, 19);
            this.rb_confir.TabIndex = 1;
            this.rb_confir.Text = "Confirmadas";
            this.rb_confir.UseVisualStyleBackColor = true;
            this.rb_confir.CheckedChanged += new System.EventHandler(this.rb_confir_CheckedChanged);
            // 
            // rb_aprob
            // 
            this.rb_aprob.AutoSize = true;
            this.rb_aprob.Checked = true;
            this.rb_aprob.Location = new System.Drawing.Point(6, 22);
            this.rb_aprob.Name = "rb_aprob";
            this.rb_aprob.Size = new System.Drawing.Size(101, 19);
            this.rb_aprob.TabIndex = 0;
            this.rb_aprob.TabStop = true;
            this.rb_aprob.Text = "En aprobacion";
            this.rb_aprob.UseVisualStyleBackColor = true;
            this.rb_aprob.CheckedChanged += new System.EventHandler(this.rb_aprob_CheckedChanged);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(353, 468);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Visible = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // VerRequis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerRequis";
            this.Text = "VerRequis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton rb_aprob;
        private RadioButton rb_confir;
        private RadioButton rb_rech;
        private Button btn_eliminar;
    }
}