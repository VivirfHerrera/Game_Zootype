using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        DBConexion miConn;
        string contents = "";
        int posImg = 1;
        int score = 0;
        int totalImagenes = 18;


        private void btn_regresarlvl2_Click(object sender, EventArgs e)
        {
            PInicio pInicio = new PInicio();
            pInicio.Show();
            this.Dispose();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            contents = ObtenerNombre(posImg.ToString());
            Console.WriteLine(contents);

            if (tb_write.Text.ToLower().CompareTo(contents.ToLower()) == 0)
            {
                if (posImg == totalImagenes)
                {
                    posImg = 0;
                    score++;
                    Points2.Text = "" + score;
                    nuevoBg();
                    tb_write.Clear();
                }
                else
                {
                    posImg++;
                    score++;
                    Points2.Text = "" + score;
                    contents = ObtenerNombre(posImg.ToString());
                    ActualizaAnimales(Imgdescrlvl2, posImg.ToString());
                    Animalname2.Text = contents;
                    Animalname2.Update();
                    nuevoBg();
                    tb_write.Clear();

                    if (score == 15)
                    {
                        string message = "¡Felicidades Completaste El Nivel Intermedio Con 15 Puntos!";
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
            else
            {
                if (score > 0)
                {
                    score--;
                }
                Points2.Text = "" + score;
                tb_write.Clear();
            }
        }
        private void ActualizaAnimales(PictureBox sech, String id)
        {
            try
            {
                SqlCommand consulta;
                consulta = new SqlCommand("SELECT imagen FROM pdss1.[dbo].[animaleslvl2] where id_animal = " + id, miConn.ConectaSQL());
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
                consulta = new SqlCommand("SELECT nombre FROM pdss1.[dbo].[animaleslvl2] where id_animal = " + id, miConn.ConectaSQL());
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                string nombre = (string)consulta.ExecuteScalar();

                return nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
            return null;
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
            miConn = new DBConexion();
            ActualizaAnimales(Imgdescrlvl2, posImg.ToString());
            contents = ObtenerNombre(posImg.ToString());
            Animalname2.Text = contents;
            Console.WriteLine(posImg);
            nuevoBg();
        }

        private void lblp2_Click(object sender, EventArgs e)
        {

        }
    }
}
