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
    public partial class PRecord : Form
    {
        public PRecord()
        {
            InitializeComponent();
        }
        private void ActualizaPuntaje()
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[r_lvl1]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_puntajes.Columns.Clear();
                dgv_puntajes.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }

        }

        private void PRecord_Load(object sender, EventArgs e)
        {
            ActualizaPuntaje();
        }

        private void btnregrecord_Click(object sender, EventArgs e)
        {
            PMenu pMenu = new PMenu();
            pMenu.Show();
            this.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[r_lvl1]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_puntajes.Columns.Clear();
                dgv_puntajes.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[r_lvl2]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_puntajes.Columns.Clear();
                dgv_puntajes.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DBConexion miConn = new DBConexion();
                String consulta = "SELECT * FROM pdss1.[dbo].[r_lvl3]";
                DataTable xTabla = miConn.ejecutaSelect(consulta, new SqlParameter[0]);

                dgv_puntajes.Columns.Clear();
                dgv_puntajes.DataSource = xTabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los usuarios desde la Base de Datos."
                            + " Error: " + ex.ToString());
            }
        }
    }
}
