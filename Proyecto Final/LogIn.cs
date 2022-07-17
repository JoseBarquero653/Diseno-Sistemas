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
using Proyecto_Final.Admin;
using Proyecto_Final.Usuario;
using Proyecto_Final.Aprobadores;

namespace Proyecto_Final
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registro = new RegistrarUsuario();
            registro.Visible = true;
            this.Visible = false;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Validar();
        }
        void Validar()
        {
            //LLAMADO A LOS FOLDERS
            MenuAdmin menuAdmin = new MenuAdmin();
            MenuUsuario menuUsuario = new MenuUsuario();
            MenuAprobador menuAprobador = new MenuAprobador();
            //OBTENER USUARIO Y CLAVE
            string usuario = txt_usuario.Text.Trim();
            string clave = txt_contraseña.Text.Trim();
            //STRING PARA LA CONEXION
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM USUARIO WHERE USUARIO ='" + usuario + "' AND CONTRASENA='" + clave + "'", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (usuario == "admin" || usuario == "ADMIN" )
                    {
                        menuAdmin.Visible = true;
                        this.Visible = false;
                        usuarioLoggeado.usuarioLogged = usuario;
                    }
                    else
                    {

                        menuUsuario.Visible = true;
                        this.Visible = false;
                        usuarioLoggeado.usuarioLogged = usuario;
                    }
                }
                else
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM APROBADOR WHERE USUARIO ='" + usuario + "' AND CONTRASENA='" + clave + "'", sqlCon);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);
                    if (dt1.Rows.Count == 1)
                    {
                        menuAprobador.Visible = true;
                        this.Visible = false;
                        usuarioLoggeado.usuarioLogged = usuario;
                    }
                    else
                    {
                        MessageBox.Show("El usuario y la contraseña no coinciden.");
                    }
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}