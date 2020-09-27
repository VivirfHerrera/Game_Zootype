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
    public partial class Pantallacarga : Form
    {
        public Pantallacarga()
        {
            InitializeComponent();
        }

        private void Pantallacarga_Load(object sender, EventArgs e)
        {
            trespuntos.Parent = pictureBox1;
            trespuntos.BackColor = Color.Transparent;
        }
        public void Provarcarga()
        {
            CargaBar.Increment(1);
            trespuntos.Text = CargaBar.ToString() + "%";
            if (CargaBar.Value == CargaBar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                PMenu ff = new PMenu();
                ff.Show();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Provarcarga();
        }
    }
}
