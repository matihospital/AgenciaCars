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

        public FAC_Ventas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.FACTURASDET' table. You can move, or remove it, as needed.
            //this.fACTURASDETTableAdapter.Fill(this.agenciaCarsDataSet.FACTURASDET);
            this.tipoComprobante.Text = "FACTURA DE VENTA";
            this.fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Clientes
            this.cmbCliente.DataSource = this.obj_clientes.buscarClientes();
            this.cmbCliente.DisplayMember = "apellido";
            this.cmbCliente.ValueMember = "idCliente";

            //Vendedores
            this.cmbVendedor.DataSource = this.obj_vendedores.buscarVendedores();
            this.cmbVendedor.DisplayMember = "apellido";
            this.cmbVendedor.ValueMember = "idVendedor";

        }

        private void actualizarGrilla()
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.cLIENTESTableAdapter.Fill(this.agenciaCarsDataSet.CLIENTES);


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO FACTURAS (idFactura) 
                           VALUES ('" + this.IdFactura.Text + ", "
                                      + "')";
            _BD.insert_update_delete(sql);
            this.actualizarGrilla();
        
        }

    }
}
