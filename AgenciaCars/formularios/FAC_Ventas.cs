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
    public partial class FAC_Ventas : Form
    {
        acceso_BD _BD = new acceso_BD();
        clientes obj_clientes = new clientes();
        vendedores obj_vendedores = new vendedores();
        productos obj_productos = new productos();

        public FAC_Ventas()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("El campo CANTIDAD no puede estar vacío.");
                this.txtCantidad.Focus();

            }
            else if (int.Parse(this.txtCantidad.Text) <= 0)
            {
                MessageBox.Show("La cantidad no puede ser menor a 1");
            }

            else
            {
                    DataTable producto = new DataTable();
                    producto = obj_productos.buscar_por_id(this.cmbProducto.SelectedValue.ToString());

                    if (dataGridView1.Rows.Count == 0)
                    {
                        this.dataGridView1.Columns.Add("orden", "Orden");
                        this.dataGridView1.Columns.Add("idProducto", "Id");
                        this.dataGridView1.Columns.Add("producto", "Producto");
                        this.dataGridView1.Columns.Add("precio", "Precio");
                        this.dataGridView1.Columns.Add("cantidad", "Cantidad");
                        this.dataGridView1.Columns.Add("total", "Total");
                    }

                    int index = dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells["orden"].Value = index + 1;
                    this.dataGridView1.Rows[index].Cells["idProducto"].Value = producto.Rows[0]["Id"];
                    this.dataGridView1.Rows[index].Cells["producto"].Value = producto.Rows[0]["Producto"];
                    this.dataGridView1.Rows[index].Cells["precio"].Value = producto.Rows[0]["Precio"]; ;
                    this.dataGridView1.Rows[index].Cells["cantidad"].Value = this.txtCantidad.Text;
                    this.dataGridView1.Rows[index].Cells["total"].Value = int.Parse(producto.Rows[0]["Precio"].ToString()) * int.Parse(this.txtCantidad.Text);

                    this.txtTotal.Text = (Convert.ToInt32(this.txtTotal.Text) + Convert.ToInt32(this.dataGridView1.Rows[index].Cells["total"].Value)).ToString();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {

            this.tipoComprobante.Text = "FACTURA DE VENTA";
            this.txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Clientes
            this.cmbCliente.DataSource = this.obj_clientes.buscarClientes();
            this.cmbCliente.DisplayMember = "Cliente";
            this.cmbCliente.ValueMember = "Id";

            //Vendedores
            this.cmbVendedor.DataSource = this.obj_vendedores.buscarVendedores();
            this.cmbVendedor.DisplayMember = "Vendedor";
            this.cmbVendedor.ValueMember = "Id";

            //Productos
            this.cmbProducto.DataSource = this.obj_productos.buscarNombreProductosStock();
            this.cmbProducto.DisplayMember = "Producto";
            this.cmbProducto.ValueMember = "Id";

            this.txtCantidad.Text = "1";
            this.txtTotal.Text = "0";

        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            //Validar que no haya campos vacios
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

                DataTable existe = _BD.consulta("SELECT ISNULL( (SELECT 1 from facturas where ptoVenta = " + this.txtPuntoVenta.Text + " and nroFactura = " + this.txtNumero.Text + " and tipoComprobante = 'V'),0) as existe ");
                if (existe.Rows[0]["existe"].ToString() == "1")
                {
                    MessageBox.Show("Ya existe una factura para ese punto de venta y ese numero");
                }
                else {
                
                    DataTable consultaId = _BD.consulta("SELECT ISNULL(max(idFactura),0)+1 as idFactura from facturas");
                    int id = int.Parse(consultaId.Rows[0]["idFactura"].ToString());


                    string sql = @"INSERT INTO FACTURAS (idFactura, 
                                                         tipoComprobante,
                                                         ptoVenta,
                                                         nroFactura,
                                                         fecha,
                                                         idCliente,
                                                         idVendedor,
                                                         total,
                                                         descripcion,
                                                         idEstado) 
                                   VALUES (" + id + ", "
                                             + " 'V' , "
                                             + this.txtPuntoVenta.Text + ", "
                                             + this.txtNumero.Text + ", "
                                             + "convert(datetime, '" + this.txtFecha.Text + "', 103)" + ", "
                                             + int.Parse(this.cmbCliente.SelectedValue.ToString()) + ", "
                                             + int.Parse(this.cmbVendedor.SelectedValue.ToString()) + ", "
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
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
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

                            //Actualizo Stock
                            string sqlStock = @"UPDATE STOCK
                                                SET cantidad = cantidad - " + dataGridView1.Rows[i].Cells["cantidad"].Value +
                                                " WHERE idProducto = " + dataGridView1.Rows[i].Cells["idProducto"].Value;
                            _BD.insert_update_delete(sqlStock);
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            _BD.iniciar_transaccion();

            //Anulo la factura
            if (this.IdFactura.Text != null)
            {
                string sqlAnular = @"UPDATE facturas 
                                     SET idEstado = 9
                                     WHERE idFactura = " + this.IdFactura.Text;
                _BD.insert_update_delete(sqlAnular);

                //Actualizo Stock
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sqlStock = @"UPDATE STOCK
                                        SET cantidad = cantidad + " + dataGridView1.Rows[i].Cells["cantidad"].Value +
                                        " WHERE idProducto = " + dataGridView1.Rows[i].Cells["idProducto"].Value;
                    _BD.insert_update_delete(sqlStock);
                }

                _BD.cerrar_transaccion();
            }
            else
            {
                MessageBox.Show("No se pudo anular la factura. Primero grabe los cambios.");
                _BD.cerrar_transaccion();
            }
        }

    }
}
