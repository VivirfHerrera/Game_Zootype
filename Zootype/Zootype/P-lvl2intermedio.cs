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

        string[] imagenes;
        string contents = "";
        int posImg = 0;


        private void btn_regresarlvl2_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }

        
        int score = 0;
        private void btnValidar_Click(object sender, EventArgs e)
        {
            
            
            contents = Properties.Resources.ResourceManager.GetString("-" + imagenes[posImg] + "1").ToLower();
            Console.WriteLine(contents);
            if (escribanimalname2.Text.ToLower().CompareTo(contents) == 0)
            {
                if (posImg == imagenes.Length - 1)
                {
                    posImg = 0;
                    score++;
                    Points2.Text = "" + score;
                    nuevaImagen();
                    nuevoBg();
                    escribanimalname2.Clear();
                }
                else
                {
                    score++;
                    Points2.Text = "" + score;
                    nuevaImagen();
                    nuevoBg();
                    escribanimalname2.Clear();
                }
            }
            else if (!(escribanimalname2.Text.ToLower().CompareTo(contents) == 0) && score > 0)
            {
                score--;
                Points2.Text = "" + score;
                escribanimalname2.Clear();
            }
        }

        public void nuevaImagen()
        {
            if (posImg < imagenes.Length - 1)
            {
                posImg++;
                Imgdescrlvl2.Image = (Image)Properties.Resources.ResourceManager.GetObject("-" + imagenes[posImg]);
                contents = Properties.Resources.ResourceManager.GetString("-" + imagenes[posImg] + "1");
                Animalname2.Text = contents;
            }

        }
        public void nuevoBg()
        {
            if (posImg >= 0 && posImg <= 6)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F21");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (posImg >= 7 && posImg <= 12)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F22");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (posImg >= 13 && posImg <= 18)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F23");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void P_lvl2Intermedio_Load_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(1, 19);
            String[] a = new String[18];

            for (int i = 1; i <= a.Length; i++)
            {
                if (i < 10)
                {
                    a[i - 1] += "0";
                }
                a[i - 1] += i;
            }
            imagenes = a.OrderBy(x => random.Next()).ToArray();
            Imgdescrlvl2.Image = (Image)Properties.Resources.ResourceManager.GetObject("-" + imagenes[0]);
            contents = Properties.Resources.ResourceManager.GetString("-" + imagenes[posImg] + "1");
            Animalname2.Text = contents;
            nuevoBg();
        }

        private void lblp2_Click(object sender, EventArgs e)
        {

        }
    }
}
