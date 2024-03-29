﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.clases;

namespace AgenciaCars.clases
{
    public class TextBox01 : TextBox
    {
        //Definición de variables locales y propiedades para la interacción con las variables
        //para establecer nombre de la tabla sobre la que actua este dato, nombre del campo
        //de la tabla (campo), el mensaje de error, si el dato es alidable, y el tipo de dato
        //que recibe el objeto.

        public enum tipo_dato { texto, numero }
        string nombre_tabla;
        string campo;
        string mensaje_error;
        bool validable;
        tipo_dato tipo;

        public tipo_dato _tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

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

    }
}
