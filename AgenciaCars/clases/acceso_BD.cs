using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AgenciaCars.clases
{
    class acceso_BD
    {
        //se utiliza las clase "OleDB" 
        //OleDbConnection es el objeto conexion con la base de datos
        OleDbConnection conexion = new OleDbConnection();
        //OleDbCommand es el objeto comando que ejecuta los comandos SQL contra
        //la base de datos
        OleDbCommand cmd = new OleDbCommand();
        //la cadena de conexion es el conjunto de instrucciones que requiere el objeto 
        //conexion para lograr una conexion exitosa con la base de datos.
        //Recuerde que para probar el sistema UD. debe crear la cadena de conexión que sirva
        //a la conexión con la base de datos donde este por utilizar este recurso. 
        string cadena_conexion = "Provider=SQLNCLI11;Data Source=MATI\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AgenciaCars;";
        //string cadena_conexion = "Provider=SQLNCLI11;Data Source=NBDELLPABLO;Integrated Security=SSPI;Initial Catalog=AgenciaCars";
        
        // cadena_conexion = "Provider=SQLNCLI11;Data Source=maquis;Persist Security Info=True;User ID=avisuales1;Initial Catalog=_TRATAMIENTO_ERRORES;password=avisuales1";


        public enum resultado_acceso { error, correcto }
        public enum tipo_conexion { simple, transaccion }
        resultado_acceso control_transaccion = resultado_acceso.correcto;
        tipo_conexion analisis_tipo_transaccion = tipo_conexion.simple;
        OleDbTransaction transaccion;

        //método conecar, se realiza cada vez que se requiere una nueva acción contra
        //la base de datos.
        //Se utiliza la metodología de acceso instantaneo, que consta de conecar puntualmente
        //con la base de datos para una acción determinada y luego de ello, se desconecta de
        //la base de datos. 
        private void conectar()
        {
            //se asiga a la propiedad connectionstring el valor de la cadena de conexion
            conexion.ConnectionString = cadena_conexion;
            //se abre la conexión, se genera el pipe con la base de datos
            conexion.Open();
            //se notifica al objeto comando sobre que conexion debe trabarjar
            cmd.Connection = conexion;
            //se configura el tipo de comando a comando de texto (escrito en el programa)
            cmd.CommandType = CommandType.Text;
        }
        private void cerrar()
        {
            //al final de la acción con la base de datos se cierra la conexión
            conexion.Close();
        }
        //se declara una función pública "consulta" para ejecutar un comando SQL del tipo SELECT
        //esta función devuelve un objeto del tipo DataTable
        public DataTable consulta(string comando)
        {
            //se ejectua el método conectar()
            conectar();
            //se le asigna al objeto "cmd" el comando de texto que debe ejecutar en la base
            //de datos
            cmd.CommandText = comando;
            //se crea un DataTable donde receptar los datos devueltos por la base de datos por
            //la ejecución del "CommandText"
            DataTable tabla = new DataTable();
            //dos acciones aquí
            //1º se ejecuta el comando SQL a travéz del objeto "cmd" => cmd.ExecuteReader()
            //2º se carga el DataTable con el resultado de la ejecución del comando 
            // => tabla.Load(. . . . 
            tabla.Load(cmd.ExecuteReader());
            //se ejecuta el método cerrar()
            cerrar();
            //se devuelte el contenido de la tabla, que contiene el resultado de la ejecución
            //de cmd
            return tabla;
        }
        //se crea un método para ejecutar comando SQL del tipo INSERT o UPDATE
        public void grabar_modificar(string comando)
        {
            //se conecta con la base de datos
            conectar();
            //se le asigna al objeto "cmd" el comando de texto que debe ejecutar en la base
            //de datos
            cmd.CommandText = comando;
            //se ejecuta un comando del tipo no consulta => ExecuteNonQuery()
            //la diferencia de un ExecuteNonQuery() con respecto a ExecuteReader() es 
            //que en el primero se ejecuta un comando que acciona en la base de datos pero no
            //trae datos de vuelta para la aplicación en si.
            //el ExecuteReader() siempre trae datos desde la base de datos a la aplicación
            //salvo que la consulta haya resultado vacia de datos o que se haya producido
            //un error en el comando
            cmd.ExecuteNonQuery();
            //se cierra la conexión 
            cerrar();
        }

        //Función para formatear datos que serán usados en comando SQL del tipo INSERT O UPDATE.
        //Ingresan por parámetro el dato y el tipo de dato que es una propiedad del objeto 
        //TextBox01, con esto determina si se debe agregar comillas a la expresión que viene
        //en dato o no. 
        private string formatear_dato(string dato, TextBox01.tipo_dato tipo)
        {
            switch (tipo)
            {
                case TextBox01.tipo_dato.texto:
                    return "'" + dato.Trim() + "'";
                //break;
                case TextBox01.tipo_dato.numero:
                    return dato.Trim();
                //break;
            }
            return dato.Trim();
        }

        public resultado_acceso insert_update_delete(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return resultado_acceso.error;
            }
            cerrar();
            return resultado_acceso.correcto;
        }
    }
}
