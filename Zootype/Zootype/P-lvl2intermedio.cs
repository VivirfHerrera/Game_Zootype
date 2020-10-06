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
    public partial class P_lvl2intermedio : Form
    {
        public P_lvl2intermedio()
        {
            InitializeComponent();
        }

        private void btn_regresarlvl2_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }
    }
}
