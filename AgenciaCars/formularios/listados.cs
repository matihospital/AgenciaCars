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
    public partial class listados : Form
    {
        public listados()
        {
            InitializeComponent();
        }

        private void listados_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            iniciarEstadistica();
        }

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
                    FROM CLIENTES as cli, 
                         TIPOS_DOCUMENTOS as tpd
                    WHERE cli.idTipoDoc = tpd.idTipoDoc";
            tabla = bd.consulta(sql);

            if (tabla.Rows.Count == 0) {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }

            datosListasEstadisticasBindingSource.DataSource = tabla;
            reportViewer1.RefreshReport();
        }

        private void iniciarEstadistica()
        {
            acceso_BD bd = new acceso_BD();
            string sql = "";

            sql = @"SELECT prov.descripcion as descriptor,
                           count(1) as dato
                    FROM CLIENTES as cli, 
                         LOCALIDADES as loc,
                         PROVINCIAS as prov
                    WHERE cli.idLocalidad = loc.idLocalidad
                    AND loc.idProvincia = prov.idProvincia
                    GROUP BY prov.descripcion ";

            EstadisticasBindingSource.DataSource = bd.consulta(sql);
            this.reportViewer2.RefreshReport();
        }
    }
}
