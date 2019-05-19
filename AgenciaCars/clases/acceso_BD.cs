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
        //Método que automatiza un comando INSERT de SQL.
        //Recibe dos parámetros. El primero son todos los objetos de un formulario en donde se
        //cargan los datos con los que se realizará el insert. El segundo parámetro es el nombre
        //de la tabla.
        public void insert_automatizado(Control.ControlCollection controles, string nombre_tabla)
        {
            //Se definen tres variables del tipo string. Columnas servirá para armar la parte del 
            //comando INSERT referida a la colección de columnas del mismo. Valores hará lo mismo
            //pero para los valores de asignación a cada columna. SqlInsert será la variable donde
            //se termine de armar el comando completo. 

            string columnas = "";
            string valores = "";
            string sqlinsert = "";
            //Con el comando foreach se crecorre todos los objetos del formulario para realizar un
            //análisis de los que son utilizados para crear el comando INSERT.
            //En este caso, sólo se atenderá los objetos del tipo: TextBox01 y ComboBox01, que son 
            //los tipos de objetos que contiene información con datos utiles. Para un sistema de mayor
            //envergadura habrá que agregar el análisis de mayor variedad de objetos, lo que conlleva 
            //a la creación de otro objetos utilizables.

            foreach (Control item in controles)
            {
                //El switch discrimina por el nombre del tipo de objeto.
                switch (item.GetType().Name)
                {
                    //Análisis del tipo TextBox01
                    case "TextBox01":
                        //Se pregunta por el nombre de tabla que viene en la propiedad -nombre_tabla- de
                        //TextBox01 si es distinto a nombre_tabla que es parámetro de entrada, que 
                        //contiene el nombre de la tabla sobre el que realizaremos el insert.
                        if (((TextBox01)item)._nombre_tabla != nombre_tabla)
                        {
                            //Si el nombre de tabla es distinto, no es de interes el dato y se corta
                            //el proceso de análisis con el comando -continue- y vuelve a la cabecera 
                            //del foreach para continuar con el siguiente objeto.
                            continue;
                        }
                        //En caso de ser igual los nombres de tabla, se continua con el nombre del campo.
                        //Se analiza si el nombre del campo que viene en el objeto esta vacío.
                        if (((TextBox01)item)._campo == "")
                        {
                            //En caso de estar vacío, también se corta el proceso de análisis con -continue-
                            //, y se vuelve a iniciar el proceso en foreach con el siguiente objeto. 
                            continue;
                        }
                        //Habiendo pasado los dos controles anteriores, se procede a construir el paquete de
                        //columnas y el paquete de datos. Para este caso hay una diferencia en la concatenación
                        //de la primera columna y el primer valor, en este caso no debe hacer comas que separen 
                        //elementos pues son los primeros. Por ello se realiza la pregunta por uno de las dos
                        //varialbes para ver si está vacia. En ambas salidas de la pregunta se realiza la misma
                        //accion con la diferencia que en una hay una coma en la concatenación.
                        if (columnas == "")
                        {
                            columnas = columnas + ((TextBox01)item)._campo;
                            //La concatenación de los valores, requiere un tratamiento especial para los del tipo
                            //de texto y de fecha, es necesario que estén delimitados con comillas simples, para 
                            //esto se diseño una función que recibe por parámetro de entrada el dato y el tipo de
                            //dato questá declarado en el TextBox01 (propiedad creada para este momento).
                            //Si el tipo de dato lo requiere, la función le agregará las comillas simples, para los
                            //demás casos no. 
                            valores = valores + this.formatear_dato(((TextBox01)item).Text, ((TextBox01)item)._tipo);
                        }
                        else
                        {
                            columnas = columnas + ", " + ((TextBox01)item)._campo;
                            valores = valores + ", " + this.formatear_dato(((TextBox01)item).Text, ((TextBox01)item)._tipo); ;
                        }
                        break;
                    //El tratamiento del ComboBox01 es de las mismas características que el de TextBox01.
                    case "ComboBox01":
                        if (((ComboBox01)item)._nombre_tabla != nombre_tabla)
                        {
                            continue;
                        }
                        if (((ComboBox01)item)._campo == "")
                        {
                            continue;
                        }
                        //El valor de devuelto pel el ComboBox01 siempre es numérico, no hace
                        //falta realizar un analisis del tipo de dato. 
                        if (columnas == "")
                        {
                            columnas = columnas + ((ComboBox01)item)._campo;
                            valores = valores + ((ComboBox01)item).SelectedValue.ToString();
                        }
                        else
                        {
                            columnas = columnas + ", " + ((ComboBox01)item)._campo;
                            valores = valores + ", " + ((ComboBox01)item).SelectedValue.ToString(); ;
                        }
                        break;
                    default:
                        break;
                }
            }
            //Construir el comando INSERT concatenando las expresiones estaticas con el 
            //contenido de las variables que se construyeron y el parámetro de entrada
            //que contiene el nombre de la tabla
            sqlinsert = @"INSERT INTO " + nombre_tabla
                        + " (" + columnas + ") VALUES (" + valores + ")";
            //MessageBox.Show(sqlinsert);
            //Transfiere el comando SQL por parámetro al método que se encuarga
            //de ejecutar comandos, llamada grabar_modificar.
            this.grabar_modificar(sqlinsert);
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
    }
}
