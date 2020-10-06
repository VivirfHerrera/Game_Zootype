﻿using System;
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
        public P_lvl1Principiante()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int score = 0;
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            contents = Properties.Resources.ResourceManager.GetString("_" + imagenes[posImg] + "1").ToLower();
            Console.WriteLine(contents);
            if (tb_write.Text.ToLower().CompareTo(contents) == 0)
            {
                score++;
                Points1.Text = "" + score;
                nuevaImagen();
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
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }

        

        private void lblp1_Click(object sender, EventArgs e)
        {

        }
    }
}
