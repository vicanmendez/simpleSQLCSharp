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

namespace ABTurnos
{
    public partial class Reportes : Form
    {
        private String nombre;

        public Reportes(String nombre)
        {
            InitializeComponent();
            DataTable dtReportesHoy = new DataTable("reportes_hoy");

            Conexion con = new Conexion();

            try
            {
                if (nombre == "turnosDeHoy")
                {
                    //Método definido en la clase Conexion
                    con.llenarTablaConProcedimiento("verTurnosDeHoy", dtReportesHoy);
                } else if(nombre == "consultasComunes")
                {

                    con.llenarTablaConConsulta("Consulta común", dtReportesHoy);
                }
                else if (nombre == "consultasEspeciales")
                {

                    con.llenarTablaConProcedimientoParametro("tipo", "Consulta especialista", "verTurnosPorTipo", dtReportesHoy);
                }
                //Llenar dataGridView con dataTable
                dataGridView.DataSource = dtReportesHoy;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha habido un error del tipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtReportesHoy = null;
            }
        }

      

        private void Reportes_Load(object sender, EventArgs e)
        {
         
            

        }
    }
}
