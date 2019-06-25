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
    class productos
    {
        acceso_BD _BD = new acceso_BD();

        int _idProducto;
        string _descripcion;
        int _anio;
        int _idModelo;
        string _color;
        float _precio;
        int _idProveedor;
        int _idPais;
        int _idEstado;

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

        public int idModelo
        {
            get { return this._idModelo; }
            set { this._idModelo = value; }
        }

        public string color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        public float precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        public int idProveedor
        {
            get { return this._idProveedor; }
            set { this._idProveedor = value; }
        }

        public int idPais
        {
            get { return this._idPais; }
            set { this._idPais = value; }
        }

        public int idEstado
        {
            get { return this._idEstado; }
            set { this._idEstado = value; }
        }

        public DataTable buscar_por_id(string id)
        {
            return this._BD.consulta(@"SELECT PRO.idProducto as Id, 
                                              mar.idMarca as idMarca,
                                              mar.descripcion as Marca,
                                              mod.idModelo as idModelo,
                                              mod.descripcion as Modelo,
                                              pro.anio as Año,
                                              pro.color as Color,
                                              pro.precio as Precio,
                                              pro.descripcion as Observaciones,
                                              pro.idPais as idPais,
                                              pro.idEstado as idEstado,
                                              pro.idProveedor as idProveedor, 
                                              (MAR.descripcion + ' ' +  mod.descripcion + ' ' + CONVERT(varchar(10),PRO.anio)) as Producto 
                                       FROM PRODUCTOS as PRO, MODELOS as mod, MARCAS as MAR 
                                       WHERE PRO.idModelo = mod.idModelo 
                                       AND mod.idMarca = mar.idMarca 
                                       AND PRO.idProducto =" + id);
        }

        public DataTable buscarProductos()
        {
            return this._BD.consulta(@"SELECT pro.idProducto as Id,
                                              mar.descripcion as Marca,
                                              mod.descripcion as Modelo,
                                              pro.anio as Año,
                                              pro.color as Color,
                                              pro.precio as Precio,
                                              pro.descripcion as Observaciones
                                      FROM productos as pro,
                                           marcas as mar,
                                           modelos as mod
                                      WHERE pro.idModelo = mod.idModelo
                                      AND mod.idMarca = mar.idMarca");
        }

        public DataTable buscarNombreProductos()
        {
            return this._BD.consulta(@"SELECT pro.idProducto as Id,
                                              mar.descripcion as Marca,
                                              mod.descripcion as Modelo,
                                              pro.anio as Año,
                                              pro.color as Color,
                                              pro.precio as Precio,
                                              pro.descripcion as Observaciones, 
                                               (MAR.descripcion + ' ' +  mod.descripcion + ' ' + CONVERT(varchar(10),PRO.anio)) Producto
                                        FROM PRODUCTOS as PRO, MODELOS as mod, MARCAS as MAR 
                                        WHERE PRO.idModelo = mod.idModelo 
                                        AND mod.idMarca = mar.idMarca");
        }

        public DataTable buscarNombreProductosStock()
        {
            return this._BD.consulta(@"SELECT pro.idProducto as Id,
                                              mar.descripcion as Marca,
                                              mod.descripcion as Modelo,
                                              pro.anio as Año,
                                              pro.color as Color,
                                              pro.precio as Precio,
                                              pro.descripcion as Observaciones, 
                                               (MAR.descripcion + ' ' +  mod.descripcion + ' ' + CONVERT(varchar(10),PRO.anio)) Producto
                                        FROM PRODUCTOS as PRO, MODELOS as mod, MARCAS as MAR, STOCK sto
                                        WHERE PRO.idModelo = mod.idModelo 
                                        AND mod.idMarca = mar.idMarca
                                        AND pro.idProducto = sto.idProducto
                                        AND sto.cantidad > 0");
        }

        public DataTable buscarPorParametro(string campo, string valor)
        {
            return this._BD.consulta("SELECT * FROM productos WHERE " + campo + " =" + valor);
        }

        public DataTable buscarSiContiene(string campo, string valor)
        {
            return this._BD.consulta("SELECT * FROM productos WHERE " + campo + " LIKE '%" + valor + "%'");
        }

        public void grabarProducto()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO productos (
                         idProducto,
                         descripcion, 
                         anio, 
                         idModelo,
                         color,
                         precio,
                         idProveedor,
                         idPais,
                         idEstado) 
                        VALUES ((select ISNULL(max(idProducto),0)+1 from productos), '" +
                         this._descripcion.ToString() + "'," +
                         this._anio + "," +
                         this._idModelo + ",'" +
                         this._color.ToString() + "'," +
                         this._precio + ", " +
                         this._idProveedor + ", " +
                         this._idPais + ", " +
                         this._idEstado + ")";
            //MessageBox.Show(SqlInsert);

            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarProducto(string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE productos 
                         SET descripcion = '" + this._descripcion.ToString() + "'"
                         + ", anio = " + this._anio
                         + ", idModelo = " + this._idModelo 
                         + ", color = '" + this._color.ToString() + "'"
                         + ", precio = " + this._precio
                         + ", idProveedor = " + this._idProveedor
                         + ", idPais = " + this._idPais 
                         + ", idEstado = " + this._idEstado
                         + " WHERE idProducto = " + _id;
            this._BD.grabar_modificar(sqlupdate);
        }

    }
}
