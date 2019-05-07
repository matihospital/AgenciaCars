using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;
using System.Windows.Forms;

namespace AgenciaCars.clases
{
    class proveedores
    {
        acceso_BD _BD = new acceso_BD();

        int _idProveedor;
        int _idTipoDoc = -1;
        int _nroDoc;
        string _apellido;
        string _nombre;
        string _calle;
        int _nro;
        string _email;
        int _idLocalidad = -1;

        public int idProveedor
        {
            get { return this._idProveedor; }
            set { this._idProveedor = value; }
        }
        public int idTipoDoc
        {
            get { return this._idTipoDoc; }
            set { this._idTipoDoc = value; }
        }
        public int nroDoc
        {
            get { return this._nroDoc; }
            set { this._nroDoc = value; }
        }
        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string calle
        {
            get { return this._calle; }
            set { this._calle = value; }
        }
        public int nro
        {
            get { return this._nro; }
            set { this._nro = value; }
        }
        public string email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public int idLocalidad
        {
            get { return this._idLocalidad; }
            set { this._idLocalidad = value; }
        }

        public DataTable buscar_por_id(string id)
        {
            return this._BD.consulta("SELECT * FROM proveedores WHERE idProveedor=" + id);
        }

        public void grabarProveedor()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO proveedores (
                         idProveedor,
                         idTipoDoc, 
                         nroDoc, 
                         apellido,
                         nombre,
                         calle,
                         nro,
                         email,
                         idLocalidad) 
                        VALUES ((select ISNULL(max(idProveedor),1) from proveedores), " +
                         this._idTipoDoc + ", " +
                         this._nroDoc + ", '" +
                         this._apellido.ToString() + "', '" +
                         this._nombre.ToString() + "', '" +
                         this._calle.ToString() + "', " +
                         this._nro + ", '" +
                         this._email.ToString() + "', " +
                         this._idLocalidad + ")";
            MessageBox.Show(SqlInsert);
            this._BD.grabar_modificar(SqlInsert);
        }
        public void modificarProveedor(string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE proveedores 
                         SET idTipoDoc ='" + this._idTipoDoc + "'"
                         + ", nroDoc = '" + this._nroDoc + "'"
                         + ", apellido = '" + this._apellido.ToString() + "'"
                         + ", nombre = '" + this._nombre.ToString() + "'"
                         + ", calle = '" + this._calle.ToString() + "'"
                         + ", nro = " + this._nro.ToString()
                         + ", email = '" + this._email.ToString() + "'"
                         + ", idLocalidad = " + this._idLocalidad.ToString()
                         + " WHERE idProveedor = " + _idProveedor;
            this._BD.grabar_modificar(sqlupdate);
        }
    }
}
