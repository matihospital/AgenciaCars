using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.clases;

namespace AgenciaCars.formularios
{
    public partial class listados : Form
    {
        public listados()
        {
            InitializeComponent();
        }

        private void listados_Load(object sender, EventArgs e)
        {
        }


        //Clientes
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT cli.idCliente,
                           tpd.descripcion as tipoDoc,
                           cli.nroDoc,
                           cli.apellido, 
                           cli.nombre,
                           cli.telefono,
                           cli.email
                    FROM CLIENTES as cli JOIN 
                    TIPOS_DOCUMENTOS as tpd ON cli.idTipoDoc = tpd.idTipoDoc
                    WHERE 1=1";

            if (!string.IsNullOrEmpty(txtPatron.Text))
            {
                int i;
                if (int.TryParse(txtPatron.Text, out i))
                {
                    sql += " AND idCliente = " + txtPatron.Text;
                }
                else
                {
                    if (txtPatron.Text.IndexOf("-") != -1)
                    {
                        string[] datos;
                        datos = txtPatron.Text.Split('-');
                        sql += @" AND idCliente BETWEEN " + datos[0]
                            + " AND " + datos[1];
                    }
                    else
                    {
                        sql += @" AND apellido like '%"
                            + txtPatron.Text.Trim() + "%'";
                    }
                }
             }

                tabla = bd.consulta(sql);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos para mostrar");
                    return;
                }

                ListadoClientesBindingSource.DataSource = tabla;
                reportViewer1.RefreshReport();
            
        }

        //Productos
        private void btn_buscar_prod_Click(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT  
                    pro.idProducto as idProducto,
                    pro.precio as Precio,
                    (MAR.descripcion + ' ' +  mod.descripcion + ' ' + CONVERT(varchar(10),PRO.anio)) as Producto,
                    pro.color as Color,
                    sto.cantidad as Disponible 
                    FROM STOCK as sto, PRODUCTOS as pro, MODELOS as mod, MARCAS as MAR 
                    WHERE sto.idProducto = pro.idProducto
                    AND pro.idModelo = mod.idModelo 
                    AND mod.idMarca = mar.idMarca";
            if (!string.IsNullOrEmpty(txtPatron.Text))
            {
                int i;
                if (int.TryParse(txtPatron.Text, out i))
                {
                    sql += " AND idProducto = " + txtPatron.Text;
                }
            }
            tabla = bd.consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            ListadoProductoBindingSource.DataSource = tabla;
            reportViewer2.RefreshReport();
        }

        //Proveedores
        private void button1_Click(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT prov.idProveedor
                    ,tpd.descripcion as tipoDoc
                    ,prov.nroDoc
                    ,prov.apellido
                    ,prov.nombre
                    ,prov.calle
                    ,prov.nro
                    ,prov.telefono
                    ,prov.email
                    ,prov.idLocalidad    
                    FROM PROVEEDORES as prov JOIN TIPOS_DOCUMENTOS AS tpd on 
                    prov.idTipoDoc = tpd.idTipoDoc
                    WHERE 1=1
                    ";
            if (!string.IsNullOrEmpty(txtPatron.Text))
            {
                int i;
                if (int.TryParse(txtPatron.Text, out i))
                {
                    sql += " AND idProveedor = " + txtPatron.Text;
                }
                else
                {
                    if (txtPatron.Text.IndexOf("-") != -1)
                    {
                        string[] datos;
                        datos = txtPatron.Text.Split('-');
                        sql += @" AND idProveedor BETWEEN " + datos[0]
                            + " AND " + datos[1];
                    }
                    else
                    {
                        sql += @" AND apellido like '%"
                            + txtPatron.Text.Trim() + "%'";
                    }
                }
            }
            tabla = bd.consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            ListadoProveedoresBindingSource.DataSource = tabla;
            reportViewer3.RefreshReport();
        }

        //Vendedores
        private void btnVendedores_Click(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT ven.idVendedor
                    ,tpd.descripcion as tipoDoc
                    ,ven.nroDoc
                    ,ven.apellido
                    ,ven.nombre
                    ,ven.calle
                    ,ven.nro
                    ,ven.telefono
                    ,ven.email
                    ,ven.idLocalidad    
                    FROM vendedores as ven JOIN TIPOS_DOCUMENTOS AS tpd on 
                    ven.idTipoDoc = tpd.idTipoDoc
                    WHERE 1=1
                    ";
            if (!string.IsNullOrEmpty(txtPatron.Text))
            {
                int i;
                if (int.TryParse(txtPatron.Text, out i))
                {
                    sql += " AND idVendedor = " + txtPatron.Text;
                }
                else
                {
                    if (txtPatron.Text.IndexOf("-") != -1)
                    {
                        string[] datos;
                        datos = txtPatron.Text.Split('-');
                        sql += @" AND idVendedor BETWEEN " + datos[0]
                            + " AND " + datos[1];
                    }
                    else
                    {
                        sql += @" AND apellido like '%"
                            + txtPatron.Text.Trim() + "%'";
                    }
                }
            }
            tabla = bd.consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            listadoVendedoresBindingSource.DataSource = tabla;
            reportViewer4.RefreshReport();

        }

        //Facturas
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT fac.idFactura as idFactura,
                           (CASE fac.tipoComprobante
                                 WHEN 'C' THEN 'Factura de Compra'
                                 WHEN 'V' THEN 'Factura de Venta'
                            END)         
                            as tipoComprobante,
                           FORMAT(fac.ptoVenta, '0000') as ptoVenta,
                           FORMAT(fac.nroFactura, '00000000') as nroFactura,
                           convert(varchar, fac.fecha, 3) as fecha,
                           (cli.nombre + ' ' + cli.apellido) as cliente,
                           FORMAT(fac.total, 'C', 'en') as total
                    FROM FACTURAS as fac, clientes as cli
                    WHERE fac.idCliente = cli.idCliente 
                    AND 1=1";
            if (!string.IsNullOrEmpty(txtPatron.Text))
            {
                int i;
                if (int.TryParse(txtPatron.Text, out i))
                {
                    sql += " AND idFactura = " + txtPatron.Text;
                }

            }
            tabla = bd.consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            listadoFacturasBindingSource.DataSource = tabla;
            reportViewer5.RefreshReport();
        }

        private void btnVendidos_Click(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "";

            sql = @"SELECT pro.idProducto as idProducto
                    , (mar.descripcion + ' ' + mod.descripcion) as producto 
                    ,pro.anio as anio
                    ,pro.color as color
                    ,FORMAT(pro.precio, 'C', 'en') as precio
                    ,convert(varchar, fac.fecha, 3) as fechaVenta
                    ,(FORMAT(fac.ptoVenta, '0000') + '-' + FORMAT(fac.nroFactura, '00000000')) as factura
                    FROM PRODUCTOS as pro, MODELOS as mod, MARCAS as mar, FACTURAS as fac, FACTURASDET as fad
                    WHERE pro.idModelo = mod.idModelo
                    AND mod.idMarca = mar.idMarca
                    AND fad.idProducto = pro.idProducto
                    and fad.idFactura = fac.idFactura
                    AND 1=1";
            if (!string.IsNullOrEmpty(txtPatron.Text))
            {
                int i;
                if (int.TryParse(txtPatron.Text, out i))
                {
                    sql += " AND idProducto = " + txtPatron.Text;
                }
            }
            tabla = bd.consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            listadoVendidosBindingSource.DataSource = tabla;
            reportViewer6.RefreshReport();
        }
    }
}