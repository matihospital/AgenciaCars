using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AgenciaCars.clases
{
    class facturas
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable buscarFacturasVenta()
        {
            return this._BD.consulta(@"SELECT fac.idFactura Id, 
                                              FORMAT(fac.ptoVenta, '0000') PV, 
                                              FORMAT(fac.nroFactura, '00000000') Numero, 
                                              (cli.apellido + ' ' + cli.nombre) Cliente, 
                                              fac.fecha as Fecha, 
                                              (ven.apellido + ' ' + ven.nombre) Vendedor,
                                              FORMAT(fac.total, 'C', 'en') Total
                                        FROM facturas as fac, clientes as cli, vendedores as ven
                                        WHERE tipoComprobante = 'V'
                                        AND fac.idCliente = cli.idCliente
                                        AND fac.idVendedor = ven.idVendedor");
        }

        public DataTable buscarFacturasCompra()
        {
            return this._BD.consulta(@"SELECT fac.idFactura Id, 
                                              FORMAT(fac.ptoVenta, '0000') PV, 
                                              FORMAT(fac.nroFactura, '00000000') Numero, 
                                              (prov.apellido + ' ' + prov.nombre) Proveedor, 
                                              fac.fecha as Fecha, 
                                              FORMAT(fac.total, 'C', 'en') Total
                                        FROM facturas as fac, proveedores as prov
                                        WHERE tipoComprobante = 'C'
                                        AND fac.idProveedor = prov.idProveedor");
        }

        public DataTable buscarPorId(string id)
        {
            return this._BD.consulta(@"SELECT fac.idFactura Id, 
                                              FORMAT(fac.ptoVenta, '0000') PV, 
                                              FORMAT(fac.nroFactura, '00000000') Numero, 
                                              prov.idProveedor Proveedor, 
                                              fac.fecha as Fecha, 
                                              fac.idEstado as Estado,
                                              fac.descripcion as Observaciones,
                                              FORMAT(fac.total, 'C', 'en') Total
                                        FROM facturas as fac, proveedores as prov
                                        WHERE tipoComprobante = 'C'
                                        AND fac.idProveedor = prov.idProveedor
                                        AND fac.idFactura = "+ id);
        }

        public DataTable buscarDetallePorId(string id)
        {
            return this._BD.consulta(@"SELECT fad.orden as Orden,
                                              fad.idProducto as idProducto,
                                              (MAR.descripcion + ' ' +  mod.descripcion + ' ' + CONVERT(varchar(10),PRO.anio)) as Producto, 
                                              fad.cantidad as Cantidad,
                                              fad.precioUnitario as Precio,
                                              (fad.cantidad * fad.precioUnitario) as Total
                                        FROM facturasdet as fad, productos as pro, modelos as mod, marcas as mar
                                        WHERE fad.idProducto = pro.idProducto
                                        AND pro.idModelo = mod.idModelo
                                        AND mod.idMarca = mar.idMarca
                                        AND fad.idFactura = " + id);
        }
    }
}
