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

namespace Proyecto_Final
{
    public partial class RegistrarUsuario : Form
    {
        string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            LogIn logIn = new LogIn();
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM USUARIO WHERE USUARIO = '" + txt_usuario.Text.Trim() + "'", sqlCon);
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
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("REGISTRAR_USUARIO", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@APELLIDO", txt_apellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@USUARIO", txt_usuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@CONTRASENA", txt_password.Text.Trim());
                    cmd.Parameters.AddWithValue("@EMAIL", txt_correo.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Existoso");
                    this.Visible = false;
                    logIn.Visible = true;
                    Clear();
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_usuario.Text = "";
            txt_password.Text = "";
            txt_correo.Text = "";
        }
    }
}
    
