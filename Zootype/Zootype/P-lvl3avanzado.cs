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
    public partial class P_lvl3avanzado : Form
    {
        public P_lvl3avanzado()
        {
            InitializeComponent();
        }

        string[] imagenes;
        string contents = "";
        int posImg = 0;

        private void btnregres3_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }

        int score = 0;
        private void btnValidar_Click(object sender, EventArgs e)
        {


            contents = Properties.Resources.ResourceManager.GetString("T" + imagenes[posImg] + "1").ToLower();
            Console.WriteLine(contents);
            if (tbdescrwrit.Text.ToLower().CompareTo(contents) == 0)
            {
                if (posImg == imagenes.Length - 1)
                {
                    posImg = 0;
                    score++;
                    Points3.Text = "" + score;
                    nuevaImagen();
                    nuevoBg();
                    tbdescrwrit.Clear();
                }
                else
                {
                    score++;
                    Points3.Text = "" + score;
                    nuevaImagen();
                    nuevoBg();
                    tbdescrwrit.Clear();
                }
            }
            else if (!(tbdescrwrit.Text.ToLower().CompareTo(contents) == 0) && score > 0)
            {
                score--;
                Points3.Text = "" + score;
                tbdescrwrit.Clear();
            }
        }

        public void nuevaImagen()
        {
            if (posImg < imagenes.Length - 1)
            {
                posImg++;
                imgnomlv3.Image = (Image)Properties.Resources.ResourceManager.GetObject("T" + imagenes[posImg]);
                contents = Properties.Resources.ResourceManager.GetString("T" + imagenes[posImg] + "1");
                tbDesc.Text = contents;
            }

        }
        public void nuevoBg()
        {
            if (posImg >= 0 && posImg <= 12)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F21");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (posImg >= 13 && posImg <= 24)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F22");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (posImg >= 25 && posImg <= 36)
            {
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("F23");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void P_lvl3Avanzado_Load_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(1, 37);
            String[] a = new String[36];

            for (int i = 1; i <= a.Length; i++)
            {
                if (i < 10)
                {
                    a[i - 1] += "0";
                }
                a[i - 1] += i;
            }
            imagenes = a.OrderBy(x => random.Next()).ToArray();
            imgnomlv3.Image = (Image)Properties.Resources.ResourceManager.GetObject("T" + imagenes[0]);
            contents = Properties.Resources.ResourceManager.GetString("T" + imagenes[posImg] + "1");
            tbDesc.Text = contents;
            nuevoBg();
        } 
    }
}
