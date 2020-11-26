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
    public partial class PMenu : Form
    {
        public PMenu()
        {
            InitializeComponent();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }
        

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            Pinstrucciones pInstrucciones = new Pinstrucciones();
            pInstrucciones.Show();
            this.Dispose();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            PRecord pRecord = new PRecord();
            pRecord.Show();
            this.Dispose();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close ZooType?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            PConfig pConfig = new PConfig();
            pConfig.Show();
            this.Dispose();
        }
    }
}
