﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AgenciaCars.clases
{
    class vendedores
    {
        acceso_BD _BD = new acceso_BD();

        int _idVendedor;
        int _idTipoDoc = -1;
        int _nroDoc;
        string _apellido;
        string _nombre;
        string _calle;
        int _nro;
        string _telefono;
        string _email;
        int _idLocalidad = -1;
        int _idEstado = 1;

        public int idVendedor
        {
            get { return this._idVendedor; }
            set { this._idVendedor = value; }
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

        public string telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
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
        public int idEstado
        {
            get { return this._idEstado; }
            set { this._idEstado = value; }
        }

        public DataTable buscar_por_id(string id)
        {
            return this._BD.consulta("SELECT * FROM vendedores WHERE idVendedor=" + id);
        }

        public DataTable buscarVendedores()
        {
            return this._BD.consulta("SELECT vendedores.*, (vendedores.apellido + ' ' + vendedores.nombre) ApeNom FROM vendedores");
        }

        public DataTable buscarPorParametro(string campo, string valor)
        {
            return this._BD.consulta("SELECT * FROM vendedores WHERE " + campo + " =" + valor);
        }

        public DataTable buscarSiContiene(string campo, string valor)
        {
            return this._BD.consulta("SELECT * FROM vendedores WHERE " + campo + " LIKE '%" + valor + "%'");
        }

        public void grabarVendedor()
        {
            //se define una variable del tipo string con la que se escrite el comando INSERT
            //SQL con el que se inserta un nuevo registro en la base de datos. 
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO vendedores (
                         idVendedor,
                         idTipoDoc, 
                         nroDoc, 
                         apellido,
                         nombre,
                         calle,
                         nro,
                         telefono,
                         email,
                         idLocalidad,
                         idEstado) 
                        VALUES ((select ISNULL(max(idVendedor),0)+1 from vendedores), " +
                         this._idTipoDoc + ", " +
                         this._nroDoc + ", '" +
                         this._apellido.ToString() + "', '" +
                         this._nombre.ToString() + "', '" +
                         this._calle.ToString() + "', " +
                         this._nro + ", '" +
                         this._telefono.ToString() + "', '" +
                         this._email.ToString() + "', " +
                         this._idLocalidad + ", " +
                         this._idEstado + ")";
 
            this._BD.insert_update_delete(SqlInsert);
        }

        public void modificarVendedor(string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE idVendedor 
                         SET idTipoDoc ='" + this._idTipoDoc + "'"
                         + ", nroDoc = '" + this._nroDoc + "'"
                         + ", apellido = '" + this._apellido.ToString() + "'"
                         + ", nombre = '" + this._nombre.ToString() + "'"
                         + ", calle = '" + this._calle.ToString() + "'"
                         + ", nro = " + this._nro
                         + ", telefono = '" + this._telefono.ToString() + "'"
                         + ", email = '" + this._email.ToString() + "'"
                         + ", idLocalidad = " + this._idLocalidad.ToString()
                         + " WHERE idVendedor = " + _idVendedor;
            this._BD.insert_update_delete(sqlupdate);
        }
    }
}