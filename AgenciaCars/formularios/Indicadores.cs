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
using System.Data;

namespace AgenciaCars.formularios
{
    public partial class Indicadores : Form
    {
        public Indicadores()
        {
            InitializeComponent();
        }

        private void listados_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //iniciarEstadistica();
        }


        private void reportUno_Load(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            //Clientes por Provincia
            sql = @"SELECT prov.descripcion as descriptor,
                           count(1) as dato
                    FROM CLIENTES as cli, 
                         LOCALIDADES as loc,
                         PROVINCIAS as prov
                    WHERE cli.idLocalidad = loc.idLocalidad
                    AND loc.idProvincia = prov.idProvincia
                    GROUP BY prov.descripcion ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer1.RefreshReport();
        }

        private void reportDos_Load(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            //Ventas por Vendedor
            sql = @"SELECT ven.apellido + ' ' + ven.nombre  as descriptor,
                           count(1) as dato
                    FROM FACTURAS as fac, 
                         VENDEDORES as ven
                    WHERE fac.idVendedor = ven.idVendedor
                    GROUP BY ven.apellido + ' ' + ven.nombre ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            //Ventas por Vendedor
            sql = @"SELECT cli.apellido + ' ' + cli.nombre  as descriptor,
                           count(1) as dato
                    FROM FACTURAS as fac, 
                         CLIENTES as cli
                    WHERE fac.idCliente = cli.idCliente
                    AND fac.tipoComprobante = 'V'
                    GROUP BY cli.apellido + ' ' + cli.nombre ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            //Autos por Marca
            sql = @"SELECT mar.descripcion  as descriptor,
                           count(1) as dato
                    FROM PRODUCTOS as pro, 
                         MODELOS as mod,
                         MARCAS as mar
                    WHERE pro.idModelo = mod.idModelo
                    and mod.idMarca = mar.idMarca
                    GROUP BY mar.descripcion ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer4.RefreshReport();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            //Compras por Mes
            sql = @"SELECT LEFT(CONVERT(varchar, fac.fecha,112),6) as descriptor,
                           sum(fad.precioUnitario) as dato
                    FROM FACTURAS as fac, 
                         FACTURASDET as fad
                    WHERE fac.idFactura = fad.idFactura
                    AND fac.tipoComprobante = 'C' 
                    GROUP BY LEFT(CONVERT(varchar, fac.fecha,112),6) ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer5.RefreshReport();
        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            //Compras por Mes
            sql = @"SELECT mod.descripcion as descriptor,
                           sum(fad.precioUnitario) as dato
                    FROM FACTURAS as fac, 
                         FACTURASDET as fad,
                         PRODUCTOS as pro,
                         MODELOS as mod
                    WHERE fac.idFactura = fad.idFactura
                    AND fac.tipoComprobante = 'V' 
                    AND fad.idProducto = pro.idProducto
                    AND pro.idModelo = mod.idModelo
                    GROUP BY mod.descripcion ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer5.RefreshReport();
        }

    }
}
