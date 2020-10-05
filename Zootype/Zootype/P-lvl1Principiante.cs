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
    public partial class P_lvl1Principiante : Form
    {
        public P_lvl1Principiante()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }
    }
}
