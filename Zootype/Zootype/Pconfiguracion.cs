using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zootype
{
    public partial class PConfig : Form
    {
        public PConfig()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            PMenu pMenu = new PMenu();
            pMenu.Show();
            this.Dispose();
        }

        private void btn_listado_Click(object sender, EventArgs e)
        {
            DatosAnimales datosAnimales = new DatosAnimales();
            datosAnimales.Show();
            this.Dispose();
        }
    }
}
