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
    public partial class FAC_Compras : Form
    {
        acceso_BD _BD = new acceso_BD();
        proveedores obj_proveedores = new proveedores();
        productos obj_productos = new productos();

        public FAC_Compras()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            this.tipoComprobante.Text = "FACTURA DE COMPRA";
            this.txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Proveedores
            this.cmbProveedor.DataSource = this.obj_proveedores.buscarProveedores();
            this.cmbProveedor.DisplayMember = "Proveedor";
            this.cmbProveedor.ValueMember = "Id";

            //Productos
            this.cmbProducto.DataSource = this.obj_productos.buscarNombreProductos();
            this.cmbProducto.DisplayMember = "Producto";
            this.cmbProducto.ValueMember = "Id";

            this.txtCantidad.Text = "0";
            this.txtTotal.Text = "0";

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Validar que no haya campos vacios (VER DE HACER UN FOR POR CADA CAMPO)

            if (this.txtPuntoVenta.Text == "")
            {
                MessageBox.Show("El campo PUNTO DE VENTA no puede estar vacío");
                this.txtPuntoVenta.Focus();
            }

            else if (this.txtNumero.Text == "")
            {
                MessageBox.Show("El campo NUMERO no puede estar vacío");
                this.txtNumero.Focus();
            }
            else if (this.txtFecha.Text == "")
            {
                MessageBox.Show("El campo FECHA no puede estar vacío");
                this.txtFecha.Focus();
            }
            else
            {
                _BD.iniciar_transaccion();

                DataTable existe = _BD.consulta("SELECT ISNULL( (SELECT 1 from facturas where ptoVenta = " + this.txtPuntoVenta.Text + " and nroFactura = " + this.txtNumero.Text + " and idProveedor = " + int.Parse(this.cmbProveedor.SelectedValue.ToString()) + " and tipoComprobante = 'C'),0) as existe ");
                if (existe.Rows[0]["existe"].ToString() == "1")
                {
                    MessageBox.Show("Ya existe una factura de ese proveedor para ese punto de venta y ese numero");
                }
                else
                {

                    DataTable consultaId = _BD.consulta("SELECT ISNULL(max(idFactura),0)+1 as idFactura from facturas");
                    int id = int.Parse(consultaId.Rows[0]["idFactura"].ToString());


                    string sql = @"INSERT INTO FACTURAS (idFactura, 
                                                         tipoComprobante,
                                                         ptoVenta,
                                                         nroFactura,
                                                         fecha,
                                                         idProveedor,
                                                         total,
                                                         descripcion,
                                                         idEstado) 
                                   VALUES (" + id + ", "
                                             + " 'C' , "
                                             + this.txtPuntoVenta.Text + ", "
                                             + this.txtNumero.Text + ", "
                                             + "convert(datetime, '" + this.txtFecha.Text + "', 103)" + ", "
                                             + int.Parse(this.cmbProveedor.SelectedValue.ToString()) + ", "
                                             + int.Parse(this.txtTotal.Text) + ", '"
                                             + this.txtDescripcion.Text + "', "
                                             + "1 "
                                             + ")";
                    _BD.insert_update_delete(sql);

                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("No puede insertar una factura sin detalle");
                        _BD.cerrar_transaccion();
                    }
                    else
                    {
                        for (int i = 1; i < dataGridView1.Rows.Count; i++)
                        {
                            string sqlDetalle = @"INSERT INTO FACTURASDET (orden,
                                                                           idFactura,
                                                                           idProducto,
                                                                           cantidad,
                                                                           precioUnitario) 
                                                VALUES (" + dataGridView1.Rows[i].Cells["orden"].Value + ", "
                                                      + id + ", "
                                                      + dataGridView1.Rows[i].Cells["idProducto"].Value + ", "
                                                      + dataGridView1.Rows[i].Cells["cantidad"].Value + ", "
                                                      + dataGridView1.Rows[i].Cells["precio"].Value
                                                      + ")";
                            _BD.insert_update_delete(sqlDetalle);
                        }
                        _BD.cerrar_transaccion();
                        blanquear_objetos();
                    }
                }
            }
        }

        private void blanquear_objetos()
        {
            this.txtPuntoVenta.Text = "";
            this.txtNumero.Text = "";
            this.txtDescripcion.Text = "";
            this.dataGridView1.Rows.Clear();
            this.txtTotal.Text = "0";
            this.txtPuntoVenta.Focus();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            DataTable producto = new DataTable();
            producto = obj_productos.buscar_por_id(this.cmbProducto.SelectedValue.ToString());

            int index = dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells["orden"].Value = index;
            this.dataGridView1.Rows[index].Cells["idProducto"].Value = producto.Rows[0]["idProducto"];
            this.dataGridView1.Rows[index].Cells["producto"].Value = producto.Rows[0]["nombreAuto"];
            this.dataGridView1.Rows[index].Cells["precio"].Value = producto.Rows[0]["precio"]; ;
            this.dataGridView1.Rows[index].Cells["cantidad"].Value = this.txtCantidad.Text;
            this.dataGridView1.Rows[index].Cells["total"].Value = int.Parse(producto.Rows[0]["precio"].ToString()) * int.Parse(this.txtCantidad.Text);

            this.txtTotal.Text = (Convert.ToInt32(this.txtTotal.Text) + Convert.ToInt32(this.dataGridView1.Rows[index].Cells["total"].Value)).ToString();
        
        }
    }
}
