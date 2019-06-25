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
    public partial class BUSQ_Ventas : Form
    {
        facturas obj_facturas = new facturas();

        public BUSQ_Ventas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Ventas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_facturas.buscarFacturasVenta();
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Busco los datos de la factura
            DataTable fac = new DataTable();
            fac = this.obj_facturas.buscarPorId(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            FAC_Ventas factura = new formularios.FAC_Ventas(fac.Rows[0]["Cliente"].ToString(),
                                                            fac.Rows[0]["Vendedor"].ToString(),
                                                            fac.Rows[0]["Estado"].ToString());

            //Cargo los datos de la factura
            factura.IdFactura.Text = fac.Rows[0]["Id"].ToString();
            factura.txtPuntoVenta.Text = fac.Rows[0]["PV"].ToString();
            factura.txtNumero.Text = fac.Rows[0]["Numero"].ToString();
            factura.txtFecha.Text = fac.Rows[0]["Fecha"].ToString();
            factura.txtDescripcion.Text = fac.Rows[0]["Observaciones"].ToString();
            factura.txtTotal.Text = fac.Rows[0]["Total"].ToString();

            factura.dataGridView1.DataSource = this.obj_facturas.buscarDetallePorId(fac.Rows[0]["Id"].ToString());
            factura.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Deshabilito para que no pueda modificar nada de la factura
            factura.IdFactura.Enabled = false;
            factura.txtPuntoVenta.Enabled = false;
            factura.txtNumero.Enabled = false;
            factura.txtFecha.Enabled = false;
            factura.cmbCliente.Enabled = false;
            factura.cmbVendedor.Enabled = false;
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (this.txt_busqueda.Text == "")
            {
                MessageBox.Show("El campo de búsqueda está vacío");
                this.txt_busqueda.Focus();
                DataTable tabla = new DataTable();
                tabla = this.obj_facturas.buscarFacturasVenta();
                dataGridView1.DataSource = tabla;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                return;
            }
            else
            {
                //inicia la busqueda de un usuario a travéz de una funcionalidad en la zona
                //de negocio llamada "buscar_por_id"
                //crea una tabla para recibir los resultados de la busqueda
                DataTable tabla = new DataTable();

                //Busco segun lo seleccionado
                if (this.ck_id.Checked)
                {
                    tabla = this.obj_facturas.buscarPorParametro("idFactura", this.txt_busqueda.Text);
                }
                else if (this.ck_nro.Checked)
                {
                    tabla = this.obj_facturas.buscarPorParametro("nroFactura", this.txt_busqueda.Text);
                }
                else if (this.ck_cliente.Checked)
                {
                    tabla = this.obj_facturas.buscarSiContiene("(cli.nombre + ' ' + cli.apellido)", this.txt_busqueda.Text);
                }
                else { return; }

                //analiza el contenido de la tabla, cuenta cantidad de filas devueltas, si
                //el valor es cero (0), no hay filas, quiere decir que no econtro ese "Id"
                //en la tabla
                //envia mensaje por tabla.Rows.Count ==0
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos");
                    this.txt_busqueda.Focus();
                    return;
                }
                dataGridView1.DataSource = tabla;
            }
        }

    }
}
