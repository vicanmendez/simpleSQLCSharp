using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Traemos librería para BD
using System.Data;
using System.Data.SqlClient;

namespace ABTurnos
{

    class Conexion{
        //Creamos el stringConnection (cambiar el nombre del servidor y la BD según corresponda)

        private SqlConnection conexion = new SqlConnection("server=DESKTOP-DI86SQL\\SQLEXPRESS ; database=turnos ; integrated security = true");
        private SqlCommand comando;

       //construct
        public Conexion()
        {

        }
        public void crearConexion()
        {
      
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        //ejecuta una sentencia en la conexion establecida
        //Precondicion: conexion creada
        public void ejecutarSentencia(String query)
        {
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

        }


        //ejecuta unprocedimiento almacenado
        //Precondicion: conexion creada
        public void llenarTablaConProcedimiento(String nombreProcedimiento, DataTable tabla)
        {
            comando = new SqlCommand(nombreProcedimiento, conexion);
            //asignar nombre del procedure al commandText
            comando.CommandText = nombreProcedimiento;
            //el commandtipe debe ser procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            //adaptador para ejecutar el comando y traer los datos a una tabla
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            //llenamos el dataTable
            adaptador.Fill(tabla);

        }

        //ejecuta UNA CONSULTA COMÚN
        //Precondicion: conexion creada
        public void llenarTablaConConsulta(String tipoConsulta, DataTable tabla)
        {
            //Crear el SqlCommand con la consulta
            comando = new SqlCommand("SELECT * FROM turno WHERE tipoTurno='"+tipoConsulta+"';", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            //llenamos el dataTable
            adaptador.Fill(tabla);

        }


        //ejecuta unprocedimiento almacenado CON UN PARÁMETRO 
        //Precondicion: conexion creada
        public void llenarTablaConProcedimientoParametro(String parametro, String valor, String nombreProcedimiento, DataTable tabla)
        {
            comando = new SqlCommand(nombreProcedimiento, conexion);
            //asignar nombre del procedure al commandText
            comando.CommandText = nombreProcedimiento;
            //el commandtipe debe ser procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            //definimos el parámetro para agregarlo al procedimiento
            SqlParameter argumento = new SqlParameter();
            // SqlParameter argumento = new SqlParameter("@"+parametro, SqlDbType.VarChar);
            //Nombre y tipo del parámetro
            argumento.ParameterName = "@"+parametro;
            argumento.SqlDbType = SqlDbType.VarChar;
            //Valor del parámetro
            argumento.SqlValue = valor;
            //Agregar argumento al comando
            comando.Parameters.Add(argumento);
            //adaptador para ejecutar el comando y traer los datos a una tabla
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            //llenamos el dataTable
            adaptador.Fill(tabla);

        }

        //ejecuta unprocedimiento almacenado CON UN PARÁMETRO 
        //Precondicion: conexion creada
        public void ejecutarProcedimientoPorId(String nombreProcedimiento, int id)
        {
            comando = new SqlCommand(nombreProcedimiento, conexion);
            //el commandtipe debe ser procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            //definimos el parámetro
            SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
            parametro.Value = id;
            //Añadimos el parámetro al comando
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

        }

        public void ejecutarProcedimientoPorNombre(String nombreProcedimiento, String nombre, DataTable dt)
        {
            comando = new SqlCommand(nombreProcedimiento, conexion);
            //el commandtipe debe ser procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            
            //definimos el parámetro
            SqlParameter parametro = new SqlParameter("@nombre", SqlDbType.VarChar);
            parametro.Value = nombre;
            //Añadimos el parámetro al comando
            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();
            adapter.Fill(dt);

        }


    }
}
