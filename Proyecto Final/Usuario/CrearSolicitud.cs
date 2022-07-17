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

namespace Proyecto_Final.Usuario
{
    public partial class CrearSolicitud : Form
    {
        string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
        public CrearSolicitud()
        {
            InitializeComponent();
            //VER EL USERNAME LOGGEADO
            string user = usuarioLoggeado.usuarioLogged;
            lbl_usuario.Text = user;
            //PONER EL NUMERO DE ORDEN APENAS SE ABRE EL FRAME
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(CODIGO_REQUI) FROM REQUISICION", sqlCon);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        int lastNum = rd.GetInt32(0);
                        int numOrden = lastNum + 1;
                        numReq.Text = numOrden.ToString();
                    }
                }

                sqlCon.Close();
            }
        }

        private void numReq_Click(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //INTRODUCIR LOS VALORES A LA BASE DE DATOS
            using SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("INSERTAR_REQUI", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CODIGO_REQUI", numReq.Text.Trim());
            cmd.Parameters.AddWithValue("@MONTO", txt_monto.Text.Trim());
            cmd.Parameters.AddWithValue("@DESCRIPCION", txt_descripcion.Text.Trim());
            cmd.Parameters.AddWithValue("@REMITENTE", lbl_usuario.Text.Trim());
            cmd.Parameters.AddWithValue("@STATUS", "Espera aprobacion");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Existoso");
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
