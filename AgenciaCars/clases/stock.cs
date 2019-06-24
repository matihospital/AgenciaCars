using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class stock
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable Consultar_Stock()
        {
            return _BD.consulta(@"SELECT sto.idStock as Id, 
                                         pro.idProducto as IdProducto,
                                         (MAR.descripcion + ' ' +  mod.descripcion + ' ' + CONVERT(varchar(10),PRO.anio)) as Producto,
                                         sto.cantidad as Disponible 
                                  FROM STOCK as sto, PRODUCTOS as pro, MODELOS as mod, MARCAS as MAR 
                                  WHERE sto.idProducto = pro.idProducto
                                  AND pro.idModelo = mod.idModelo 
                                  AND mod.idMarca = mar.idMarca");
        }
    }
}
