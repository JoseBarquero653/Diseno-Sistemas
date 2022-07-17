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
    }
}
