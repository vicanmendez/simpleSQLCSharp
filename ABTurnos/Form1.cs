using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABTurnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos desde la gráfica
            String nombre = txtNombre.Text;
            String tipo = comboTipo.SelectedItem.ToString();
            String lugar = comboLugar.SelectedItem.ToString();
            //Obtener fecha y hora del campo
            DateTime fecha = dateTime.Value.ToLocalTime();
            try
            {
                Conexion con = new Conexion();
                con.crearConexion();
                con.ejecutarSentencia("INSERT INTO TURNO(nombreCliente, tipoTurno, lugar, horafecha) VALUES('" + nombre + "', '" + tipo + "', '" + lugar + "', '" + fecha + "');");
                //MessageBox con botones e icono, recibe 4 parámetros, Texto, Título, MessageBox.Buttons y MessageBox.Icons
                MessageBox.Show("Se han ingresado los valores: \n Nombre: " + nombre + "\n Tipo: " + tipo + "\n Lugar: " + lugar + "\n Fecha: " + fecha + "", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnVerReporte.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos por: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes("turnosDeHoy");
            r.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes("consultasComunes");
            r.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes("consultasEspeciales");
            r.Visible = true;
        }
    }
}
