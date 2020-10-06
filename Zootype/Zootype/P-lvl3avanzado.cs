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
    public partial class P_lvl3avanzado : Form
    {
        public P_lvl3avanzado()
        {
            InitializeComponent();
        }

        private void btnregres3_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }
    }
}
