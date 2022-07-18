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
    public partial class VerRequis : Form
    {
        
        public VerRequis()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DataSet ds = new DataSet();
            ds = verTodasReq();
            dataGridView1.DataSource = ds.Tables[0];
        }

        public static DataSet verTodasReq()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {

                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE REMITENTE = '" + userLog + "'", sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public static DataSet verEnAprobacion()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {

                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE REMITENTE = '" + userLog + "' AND (STATUS != 'Confirmada' OR STATUS != 'Rechazada')", sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public static DataSet verConfirmadas()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {

                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE REMITENTE = '" + userLog + "' AND STATUS = 'Confirmada'", sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public static DataSet verRechazadas()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {

                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE REMITENTE = '" + userLog + "' AND STATUS = 'Rechazada'", sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_aprob_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DataSet ds = new DataSet();
            ds = verEnAprobacion();
            dataGridView1.DataSource = ds.Tables[0];
            btn_eliminar.Visible = true;
        }

        private void rb_confir_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DataSet ds = new DataSet();
            ds = verConfirmadas();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void rb_rech_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DataSet ds = new DataSet();
            ds = verRechazadas();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_req_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    string numReq = this.dataGridView1.SelectedCells[0].Value.ToString();
                    int num = int.Parse(numReq);
                    DialogResult dr = MessageBox.Show("Seguro que desea eliminar la requisicion?", "", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            SqlCommand cmd = new SqlCommand("delete  from REQUISICION where CODIGO_REQUI = '" + num + "'", sqlCon);
                            cmd.ExecuteNonQuery(); break;
                        case DialogResult.No:
                            break;
                    }
                    this.Close();


                    sqlCon.Close();
                }
            }
        }
    }
}
