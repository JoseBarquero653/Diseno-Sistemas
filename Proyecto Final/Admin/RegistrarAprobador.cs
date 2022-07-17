using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final.Admin
{
    public partial class RegistrarAprobador : Form
    {
        string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
        string tipo;
        MenuAdmin menuAdmin = new MenuAdmin();
        public RegistrarAprobador()
        {
            InitializeComponent();
        }

        private void RegistrarAprobador_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            //VERIFICAR QUE NO HAYAN QUEDADO ESPACIOS VACIOS
            using SqlConnection sqlCon = new SqlConnection(conString);
            if (txt_nombre.Text == "" || txt_apellido.Text == "" ||
               txt_usuario.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else
            {
                //VERIFICAR QUE NO HAYAN DOS USERNAMES IGUALES ANTES DE INGRESAR A LA BASE DE DATOS
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM APROBADOR WHERE USUARIO = '" + txt_usuario.Text.Trim() + "'", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Nombre de usuario ocupado");
                    txt_usuario.BackColor = Color.Red;
                    txt_usuario.Text = "";
                }
                else
                {
                 //CHECKEAR EL VALOR DEL RADIO BUTTON
                    if (rb_jefe.Checked == true)
                        tipo = "Jefe";
                    if (rb_tipo1.Checked == true)
                        tipo = "Tipo 1";
                    if (rb_tipo2.Checked == true)
                        tipo = "Tipo 2";
                    if (rb_tipo3.Checked == true)
                        tipo = "Tipo 3";

                    //INTRODUCIR LOS VALORES A LA BASE DE DATOS
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("REGISTRAR_APROBADOR", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@APELLIDO", txt_apellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@USUARIO", txt_usuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@CONTRASENA", txt_password.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMAIL", txt_correo.Text.Trim());
                    cmd.Parameters.AddWithValue("@TIPO_APROBADOR", tipo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Existoso");
                    this.Visible = false;
                    menuAdmin.Visible = true;
                    Clear();
                }

            }
        }
        void Clear()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_usuario.Text = "";
            txt_password.Text = "";
            txt_correo.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menuAdmin.Visible = true;
        }
    } 
}
