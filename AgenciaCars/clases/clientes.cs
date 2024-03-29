﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;
using System.Windows.Forms;

namespace AgenciaCars.clases
{
    class clientes
    {
       //se instancia un objeto del tipo acceso_BD, esta es la clase backEnd que iteractua
        //con la base de datos
        acceso_BD _BD = new acceso_BD();
        //se declaran las variables que soportan las propiedades publicas que son imagen de
        //la estructura de la tabla users
        int _idCliente;
        int _idTipoDoc=-1;
        int _nroDoc;
        string _apellido;
        string _nombre;
        string _calle;
        int _nro;
        string _telefono;
        string _email;
        int _idLocalidad=-1;

        //se declaran las propiedades publicas para poder ingresar los datos desde el frontEnd
        //para que la clase negocio tome los datos cargados 
        public int idCliente
        {
            get { return this._idCliente; }
            set { this._idCliente = value; }
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

        //se declara la función "buscar_por_id" que lanza la busqueda en la base de un 
        //usuario
        public DataTable buscar_por_id (string id)
        {
            return this._BD.consulta(@"SELECT cli.idCliente,
                                              cli.idTipoDoc,
                                              cli.nroDoc,
                                              cli.apellido,
                                              cli.nombre,
                                              cli.telefono,
                                              cli.email,
                                              cli.calle,
                                              cli.nro,
                                              cli.idLocalidad,
                                              prv.idProvincia,
                                              pai.idPais        
                                       FROM clientes as cli, localidades as loc, provincias as prv, paises as pai
                                       WHERE cli.idCliente = " + id +
                                       @" AND cli.idLocalidad = loc.idLocalidad
                                          AND loc.idProvincia = prv.idProvincia
                                          AND prv.idPais = pai.idPais"
                                       );
        }

        public DataTable buscarClientes()
        {
            return this._BD.consulta(@"SELECT cli.idCliente as Id,
                                              (cli.apellido + ' '+ cli.nombre) as Cliente,   
                                              tpd.descripcion as TipoDoc,
                                              cli.nroDoc as NroDoc,
                                              cli.calle as Calle,
                                              cli.nro as Numero,
                                              cli.telefono as Telefono,
                                              cli.email as Email,
                                              loc.descripcion as Localidad     
                                       FROM clientes as cli, tipos_documentos as tpd, localidades as loc
                                       WHERE cli.idTipoDoc = tpd.idTipoDoc
                                       AND cli.idLocalidad = loc.idLocalidad");
        }

        public DataTable buscarPorParametro(string campo, string valor)
        {
            return this._BD.consulta(@"SELECT cli.idCliente as Id,
                                              (cli.apellido + ' '+ cli.nombre) as Cliente,   
                                              tpd.descripcion as TipoDoc,
                                              cli.nroDoc as NroDoc,
                                              cli.calle as Calle,
                                              cli.nro as Numero,
                                              cli.telefono as Telefono,
                                              cli.email as Email,
                                              loc.descripcion as Localidad     
                                       FROM clientes as cli, tipos_documentos as tpd, localidades as loc
                                       WHERE cli.idTipoDoc = tpd.idTipoDoc
                                       AND cli.idLocalidad = loc.idLocalidad
                                       AND " + campo + " =" + valor );
        }

        public DataTable buscarSiContiene(string campo, string valor)
        {
            return this._BD.consulta(@"SELECT cli.idCliente as Id,
                                              (cli.apellido + ' '+ cli.nombre) as Cliente,   
                                              tpd.descripcion as TipoDoc,
                                              cli.nroDoc as NroDoc,
                                              cli.calle as Calle,
                                              cli.nro as Numero,
                                              cli.telefono as Telefono,
                                              cli.email as Email,
                                              loc.descripcion as Localidad     
                                       FROM clientes as cli, tipos_documentos as tpd, localidades as loc
                                       WHERE cli.idTipoDoc = tpd.idTipoDoc
                                       AND cli.idLocalidad = loc.idLocalidad
                                       AND " + campo + " LIKE '%" + valor + "%'");
        }

        //métod para garbar un nuevo registro en la base de datos en la tabla users
        public void grabarCliente()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO clientes (
                         idCliente,
                         idTipoDoc, 
                         nroDoc, 
                         apellido,
                         nombre,
                         calle,
                         nro,
                         telefono,
                         email,
                         idLocalidad) 
                        VALUES ((select ISNULL(max(idCliente),0)+1 from clientes), " +
                         this._idTipoDoc + ", " +
                         this._nroDoc + ", '" +
                         this._apellido.ToString() + "', '" +
                         this._nombre.ToString() + "', '" +
                         this._calle.ToString() + "', " +
                         this._nro + ", '" +
                         this._telefono.ToString() + "', '" +
                         this._email.ToString() + "', " +
                         this._idLocalidad+ ")";  
            this._BD.insert_update_delete(SqlInsert);
        }

        public void modificarCliente (string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE clientes 
                         SET idTipoDoc ='" + this._idTipoDoc + "'"
                         + ", nroDoc = '" + this._nroDoc + "'"
                         + ", apellido = '" + this._apellido.ToString() + "'"
                         + ", nombre = '" + this._nombre.ToString() + "'"
                         + ", calle = '" + this._calle.ToString() + "'"
                         + ", nro = " + this._nro
                         + ", telefono = '" + this._telefono.ToString() + "'"
                         + ", email = '" + this._email.ToString() + "'"
                         + ", idLocalidad = " + this._idLocalidad.ToString()
                         + " WHERE idCliente = " + _id;
            this._BD.insert_update_delete(sqlupdate);
        }
    }
}
