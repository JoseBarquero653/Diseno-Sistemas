using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Admin
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btn_aprobador_Click(object sender, EventArgs e)
        {
            RegistrarAprobador registrarAprobador = new RegistrarAprobador();
            registrarAprobador.Visible = true;
            this.Visible = false;
        }
    }
}
