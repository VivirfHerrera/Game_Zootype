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
    public partial class PInicio : Form
    {
        public PInicio()
        {
            InitializeComponent();
        }

        private void btnlvl1_Click(object sender, EventArgs e)
        {
            P_lvl1Principiante p_Lvl1 = new P_lvl1Principiante();
            p_Lvl1.Show();
            this.Dispose();
        }

        private void btnlvl2_Click(object sender, EventArgs e)
        {
            P_lvl2intermedio p_Lvl2 = new P_lvl2intermedio();
            p_Lvl2.Show();
            this.Dispose();
        }

        private void btnlvl3_Click(object sender, EventArgs e)
        {
            P_lvl3avanzado p_Lvl3 = new P_lvl3avanzado();
            p_Lvl3.Show();
            this.Dispose();
        }

        private void btnregresarPin_Click(object sender, EventArgs e)
        {
            PMenu pMenu = new PMenu();
            pMenu.Show();
            this.Dispose();
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            DatosAnimales datosAnimales = new DatosAnimales();
            datosAnimales.Show();
            this.Dispose();
        }
    }
}
