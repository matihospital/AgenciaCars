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
    public partial class BUSQ_Compras : Form
    {
        facturas obj_facturas = new facturas();

        public BUSQ_Compras()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Compras_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_facturas.buscarFacturasCompra();
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FAC_Compras factura = new formularios.FAC_Compras();

            //Busco los datos de la factura
            DataTable fac = new DataTable();
            fac = this.obj_facturas.buscarPorId(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //Cargo los datos de la factura
            factura.IdFactura.Text = fac.Rows[0]["Id"].ToString();
            factura.txtPuntoVenta.Text = fac.Rows[0]["PV"].ToString();
            factura.txtNumero.Text = fac.Rows[0]["Numero"].ToString();
            factura.txtFecha.Text = fac.Rows[0]["Fecha"].ToString();
            //PROVEEDOR
            factura.txtDescripcion.Text = fac.Rows[0]["Observaciones"].ToString();
            //ESTADO
            factura.txtTotal.Text = fac.Rows[0]["Total"].ToString();

            factura.dataGridView1.DataSource = this.obj_facturas.buscarDetallePorId(fac.Rows[0]["Id"].ToString());
            factura.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Deshabilito para que no pueda modificar nada de la factura
            factura.IdFactura.Enabled = false;
            factura.txtPuntoVenta.Enabled = false;
            factura.txtNumero.Enabled = false;
            factura.txtFecha.Enabled = false;
            factura.cmbProveedor.Enabled = false;
            factura.txtDescripcion.Enabled = false;
            factura.cmbProducto.Enabled = false;
            factura.txtCantidad.Enabled = false;
            factura.btnProducto.Enabled = false;
            factura.dataGridView1.Enabled = false;
            factura.btn_nuevo.Enabled = false;
            factura.txtTotal.Enabled = false;
            
            //Abro la pantalla
            factura.ShowDialog();
        }

    }
}
