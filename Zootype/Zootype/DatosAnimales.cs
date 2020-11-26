using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zootype
{
    public partial class DatosAnimales : Form
    {
        public DatosAnimales()
        {
            InitializeComponent();
        }
        private void ActualizaAnimales()
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[animaleslvl1]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_animales.Columns.Clear();
                dgv_animales.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void DatosAnimales_Load(object sender, EventArgs e)
        {
            ActualizaAnimales();
        }

        private void btn_lista1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[animaleslvl1]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_animales.Columns.Clear();
                dgv_animales.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void btn_lista2_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[animaleslvl2]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_animales.Columns.Clear();
                dgv_animales.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void btn_lista3_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[animaleslvl3]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_animales.Columns.Clear();
                dgv_animales.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            PConfig pConfig = new PConfig();
            pConfig.Show();
            this.Dispose();
        }
    }
}
