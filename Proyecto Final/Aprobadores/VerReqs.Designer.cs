namespace Proyecto_Final.Aprobadores
{
    partial class VerReqs
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
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_rechazar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(270, 475);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmar.TabIndex = 1;
            this.btn_confirmar.Text = "Confimar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_rechazar
            // 
            this.btn_rechazar.Location = new System.Drawing.Point(596, 475);
            this.btn_rechazar.Name = "btn_rechazar";
            this.btn_rechazar.Size = new System.Drawing.Size(75, 23);
            this.btn_rechazar.TabIndex = 2;
            this.btn_rechazar.Text = "Rechazar";
            this.btn_rechazar.UseVisualStyleBackColor = true;
            this.btn_rechazar.Click += new System.EventHandler(this.btn_rechazar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de aprobador:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(189, 46);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(38, 15);
            this.lbl_tipo.TabIndex = 4;
            this.lbl_tipo.Text = "label2";
            // 
            // VerReqs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 545);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rechazar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerReqs";
            this.Text = "VerReqs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_confirmar;
        private Button btn_rechazar;
        private Label label1;
        private Label lbl_tipo;
    }
}