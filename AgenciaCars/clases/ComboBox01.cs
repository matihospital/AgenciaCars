using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    public partial class ComboBox01 : ComboBox
    {
        //Definición de variables locales y propiedades para la interacción con las variables
        //para establecer nombre de la tabla sobre la que actua este dato, nombre del campo
        //de la tabla (campo), el mensaje de error, si el dato es alidable, y el tipo de dato
        //que recibe el objeto.

        string nombre_tabla;
        string campo;
        string mensaje_error;
        bool validable;


        public string _nombre_tabla
        {
            get { return nombre_tabla; }
            set { nombre_tabla = value; }
        }
        public string _campo
        {
            get { return campo; }
            set { campo = value; }
        }
        public string _mensaje_error
        {
            get { return mensaje_error; }
            set { mensaje_error = value; }
        }
        public bool _validable
        {
            get { return validable; }
            set { validable = value; }
        }
        //Se definen dos métodos sobrecargados (mismo nombre)
        //de carga del ComboBox01, uno requiere de una instancia de
        //la clase acceso_BD con la que accede a leer la tabla con la que se carga el combo.
        //El otro método recibe directamente la tabla con la que se carga el combo.
        //Para ambos casos se debe declarar que columna es la pk y cual el descriptor, para
        //poder configuar el ValueMember (miembro valor) y el DisplayMember (miembro display)
        public void cargar(string nombre_tabla, string pk, string descriptor)
        {
            acceso_BD _BD = new acceso_BD();
            this.DataSource = _BD.consulta("SELECT * FROM " + nombre_tabla);
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
        }
        public void cargar(DataTable tabla, string pk, string descriptor)
        {
            this.DataSource = tabla;
            this.DisplayMember = descriptor;
            this.ValueMember = pk;
        }




    }
}
