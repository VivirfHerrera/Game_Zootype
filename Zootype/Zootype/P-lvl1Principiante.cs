using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zootype
{
    public partial class P_lvl1Principiante : Form
    {
        string[] imagenes;
        string contents = "";
        int posImg = 0;
        int score = 0;
        public P_lvl1Principiante()
        {
            InitializeComponent();
        }    

        
        private void btn_verificar_Click(object sender, EventArgs e)
        {

            contents = Properties.Resources.ResourceManager.GetString("_" + imagenes[posImg] + "1").ToLower();
            Console.WriteLine(contents);
            
            if (tb_write.Text.ToLower().CompareTo(contents) == 0)
            {
                if (posImg == imagenes.Length-1)
                {
                    posImg = 0;
                    score++;
                    Points1.Text = "" + score;
                    nuevoBg();
                    tb_write.Clear();
                }
                else
                {
                    score++;
                    Points1.Text = "" + score;
                    nuevaImagen();
                    nuevoBg();
                    tb_write.Clear();

                    if (score == 15)
                    {
                        string message = "¡Felicidades Completaste El Nivel Principiante Con 10 Puntos!";
                        string title = "Close Window";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.OK)
                        {
                            PInicio pInicio = new PInicio();
                            pInicio.Show();
                            this.Dispose();
                        }
                    }
                }
            }
            else if (!(tb_write.Text.ToLower().CompareTo(contents) == 0) && score > 0)
            {
                score--;
                Points1.Text = "" + score;
                tb_write.Clear();
            }
            
        }
        public void nuevaImagen()
        {
            if (posImg < imagenes.Length - 1)
            {
                posImg++;
                ImagendescLvl1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + imagenes[posImg]);
                contents = Properties.Resources.ResourceManager.GetString("_" + imagenes[posImg] + "1");
                animalname.Text = contents;
            }

        }
        public void nuevoBg()
        {
            if (posImg >= 0 && posImg <= 6)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F11");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (posImg >= 7 && posImg <= 12)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F12");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (posImg >= 13 && posImg <= 18)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F13");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void P_lvl1Principiante_Load_1(object sender, EventArgs e)
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
            ImagendescLvl1.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + imagenes[0]);
            contents = Properties.Resources.ResourceManager.GetString("_" + imagenes[posImg] + "1");
            animalname.Text = contents;
            Console.WriteLine(posImg);
            nuevoBg();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }

    }
}
