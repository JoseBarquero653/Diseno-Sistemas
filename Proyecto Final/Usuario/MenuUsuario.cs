using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Usuario
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void btn_solicitud_Click(object sender, EventArgs e)
        {
            CrearSolicitud crearSolicitud = new CrearSolicitud();
            crearSolicitud.Visible = true;
        }

        private void btn_requis_Click(object sender, EventArgs e)
        {
            VerRequis requis = new VerRequis();
            requis.Visible = true;  

        }
    }
}
