using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaCars.clases
{
    class productos
    {
        acceso_BD _BD = new acceso_BD();

        int _idProducto;
        string _descripcion;
        int _anio;
        string _modelo;
        string _color;
        string _estado;

        public int idProducto
        {
            get { return this._idProducto; }
            set { this._idProducto = value; }
        }

        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }

        public int anio
        {
            get { return this._anio; }
            set { this._anio = value; }
        }

        public string modelo
        {
            get { return this._modelo; }
            set { this._modelo = value; }
        }

        public string color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        public string estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }


    }
}
