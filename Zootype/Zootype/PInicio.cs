﻿using System;
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

        private void btnregresarPin_Click(object sender, EventArgs e)
        {
            PMenu pMenu = new PMenu();
            pMenu.Show();
            this.Dispose();
        }
    }
}
