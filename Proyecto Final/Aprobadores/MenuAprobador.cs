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
using Proyecto_Final;
    
namespace Proyecto_Final.Aprobadores
{
    public partial class MenuAprobador : Form
    {
        
        public MenuAprobador()
        {
            InitializeComponent();
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            
           
           /* dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DataSet ds = new DataSet();
            ds = verPendientes();
            dataGridView1.DataSource = ds.Tables[0];*/
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void prueba()
        {
            string userLog = usuarioLoggeado.aprobadorLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT TIPO_APROBADOR FROM APROBADOR WHERE USUARIO= @USUARIO", sqlCon);
                cmd.Parameters.AddWithValue("@USUARIO", userLog);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        string tipo = rd["TIPO_APROBADOR"].ToString();
                        txt_prueba.Text = tipo; 
                    }
                }
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
           VerReqs ver = new VerReqs();
            ver.Visible = true;
            prueba();
            
           
        }
    }
}
