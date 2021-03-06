﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DBConexion miConn;
        string contents = "";
        int posImg = 1;
        int score = 0;
        int totalImagenes = 18;
        public P_lvl1Principiante()
        {
            InitializeComponent();
        }
        private void GuardarResultado()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source = 189.173.87.246; Initial Catalog = pdss1; "
                + " User Id= user; Password= macario;");
            con.Open();
            String st = "INSERT INTO dbo.r_lvl1(puntos) Values (@puntos)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@puntos", score);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Puntaje guardado correctamente.", "Puntaje", MessageBoxButtons.OK);


        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {

            contents = ObtenerNombre(posImg.ToString());
            Console.WriteLine(contents);
            
            if (tb_write.Text.ToLower().CompareTo(contents.ToLower()) == 0)
            {
                if (posImg == totalImagenes)
                {
                    posImg = 0;
                    score++;
                    Points1.Text = "" + score;
                    nuevoBg();
                    tb_write.Clear();
                }
                else
                {
                    posImg++;
                    score++;
                    Points1.Text = "" + score;
                    contents = ObtenerNombre(posImg.ToString());
                    ActualizaAnimales(ImagendescLvl1, posImg.ToString());
                    animalname.Text = contents;
                    animalname.Update();
                    nuevoBg();
                    tb_write.Clear();

                    if (score == 15)
                    {

                        string message = "¡Felicidades Completaste El Nivel Principiante Con 15 Puntos!";
                        string title = "Close Window";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.OK)
                        {
                            PInicio pInicio = new PInicio();
                            pInicio.Show();
                            this.Dispose();
                        }
                        GuardarResultado();
                    }
                }
            }
            else
            {
                if (score > 0)
                {
                    score--;
                }
                Points1.Text = "" + score;
                tb_write.Clear();
            }
            
        }
        private void ActualizaAnimales(PictureBox sech, String id)
        {
            try
            {
                SqlCommand consulta;
                consulta = new SqlCommand ("SELECT imagen FROM pdss1.[dbo].[animaleslvl1] where id_animal = "+id, miConn.ConectaSQL());
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["imagen"]);
                    sech.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }
        private string ObtenerNombre(String id)
        {
            try
            {
                SqlCommand consulta;
                DBConexion miConn = new DBConexion();
                consulta = new SqlCommand("SELECT nombre FROM pdss1.[dbo].[animaleslvl1] where id_animal = " + id, miConn.ConectaSQL());
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                string nombre = (string)consulta.ExecuteScalar();

                return nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            } return null;
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
            miConn = new DBConexion();
            ActualizaAnimales(ImagendescLvl1, posImg.ToString());
            contents = ObtenerNombre(posImg.ToString());
            animalname.Text = contents;
            Console.WriteLine(posImg);
            nuevoBg();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            GuardarResultado();
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }

    }
}
