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

namespace Proyecto_Final.Aprobadores
{
    public partial class VerReqs : Form
    {
        public VerReqs()
        {
            InitializeComponent();
            /*dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            DataSet ds = new DataSet();
            ds = verTodasReq();
            dataGridView1.DataSource = ds.Tables[0];*/
            string user = usuarioLoggeado.aprobadorLogged;

            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {

                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT TIPO_APROBADOR FROM APROBADOR WHERE USUARIO= @USUARIO", sqlCon);
                cmd.Parameters.AddWithValue("@USUARIO", user);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        string tipo = rd["TIPO_APROBADOR"].ToString();
                        lbl_tipo.Text = tipo;

                        if (tipo == "Jefe")
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.Refresh();
                            DataSet ds = new DataSet();
                            ds = verJefe();
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else if (tipo == "Tipo 1")
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.Refresh();
                            DataSet ds = new DataSet();
                            ds = verTipo1();
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else if (tipo == "Tipo 2")
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.Refresh();
                            DataSet ds = new DataSet();
                            ds = verTipo2();
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                        else if (tipo == "Tipo 3")
                        {
                            dataGridView1.DataSource = null;
                            dataGridView1.Refresh();
                            DataSet ds = new DataSet();
                            ds = verTipo3();
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }

            }
        }

        public  DataSet verTodasReq()
        {
            

            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT TIPO_APROBADOR FROM APROBADOR WHERE USUARIO= @USUARIO", sqlCon);
                cmd.Parameters.AddWithValue("@USUARIO", lbl_tipo.Text);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        string tipo = rd["TIPO_APROBADOR"].ToString();
                        

                        if (tipo == "Jefe")
                        {
                            verJefe();
                        }
                        else if (tipo == "Tipo 1")
                        {
                            verTipo1();
                        }
                        else if (tipo == "Tipo 2")
                        {
                            verTipo2();
                        }
                        else if (tipo == "Tipo 3")
                        {
                            verTipo3();
                        }
                    }
                    return verTipo1();


                }
                sqlCon.Close();

            }
        }
        public static DataSet verJefe()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {

                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE STATUS = 'Espera aprobacion'", sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
        public static DataSet verTipo1()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE STATUS = 'Aprobado por Jefe' ", sqlCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public static DataSet verTipo2()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE STATUS = 'Aprobado por Jefe' AND (MONTO>100000 AND MONTO<1000000)", sqlCon);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                return ds3;
            }
        }

        public static DataSet verTipo3()
        {
            string userLog = usuarioLoggeado.usuarioLogged;
            //ENSEñA EN EL GRID TODOS LOS USUARIOS REGISTRADOS MENOS EL ADMIN
            string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                SqlDataAdapter da4 = new SqlDataAdapter("SELECT * FROM REQUISICION WHERE STATUS = 'Aprobado por Jefe' AND (MONTO>1000000 AND MONTO<100000000)", sqlCon);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4);
                return ds4;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    string numReq = this.dataGridView1.SelectedCells[0].Value.ToString();
                    int num = int.Parse(numReq);
                    DialogResult dr = MessageBox.Show("Seguro que desea confirmar la requisicion?", "", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            SqlCommand cmd1 = new SqlCommand("ACTUALIZAR_STATUS", sqlCon);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@CODIGO_REQUI", num);
                            cmd1.Parameters.AddWithValue("@STATUS", "Aprobado por Jefe");
                            cmd1.ExecuteNonQuery(); 
                            break;
                        case DialogResult.No:
                            break;
                    }
                    this.Close();


                    sqlCon.Close();
                }
            }
        }

        private void btn_rechazar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string conString = @"Data Source = DESKTOP-VMSM2NF\SQLEXPRESS; Initial Catalog = 'DisenoSistemas'; Trusted_Connection = True;";
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    string numReq = this.dataGridView1.SelectedCells[0].Value.ToString();
                    int num = int.Parse(numReq);
                    DialogResult dr = MessageBox.Show("Seguro que desea rechazar la requisicion?", "", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            SqlCommand cmd1 = new SqlCommand("ACTUALIZAR_STATUS", sqlCon);
                            cmd1.CommandType = CommandType.StoredProcedure;
                            cmd1.Parameters.AddWithValue("@CODIGO_REQUI", num);
                            cmd1.Parameters.AddWithValue("@STATUS", "Rechazado");
                            cmd1.ExecuteNonQuery();
                            break;
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
