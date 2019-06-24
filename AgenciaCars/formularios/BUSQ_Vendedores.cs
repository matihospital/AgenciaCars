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
    public partial class BUSQ_Vendedores : Form
    {
        vendedores obj_vendedores = new vendedores();

        public BUSQ_Vendedores()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir ABM
            ABM_Vendedores frm = new formularios.ABM_Vendedores();
            frm.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Vendedores_Load(object sender, EventArgs e)
        {
           actualizarGrilla();
           this.txt_busqueda.Text = "";
        }

        private void actualizarGrilla()
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.cLIENTESTableAdapter.Fill(this.agenciaCarsDataSet.CLIENTES);

            DataTable tabla = new DataTable();
            tabla = this.obj_vendedores.buscarVendedores();
            dataGridView1.DataSource = tabla;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (this.txt_busqueda.Text == "")
            {
                MessageBox.Show("El campo de búsqueda está vacío");
                this.txt_busqueda.Focus();    
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
                    tabla = this.obj_vendedores.buscarPorParametro("idVendedor", this.txt_busqueda.Text);
                }
                else if (this.ck_nroDoc.Checked)
                {
                    tabla = this.obj_vendedores.buscarPorParametro("nroDoc", this.txt_busqueda.Text);
                }
                else if (this.ck_apellido.Checked)
                {
                    tabla = this.obj_vendedores.buscarSiContiene("apellido", this.txt_busqueda.Text);
                }
                else if (this.ck_nombre.Checked)
                {
                    tabla = this.obj_vendedores.buscarSiContiene("nombre", this.txt_busqueda.Text);
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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ABM_Vendedores vendedor = new formularios.ABM_Vendedores();

            //Busco los datos del cliente
            DataTable ven = new DataTable();
            ven = this.obj_vendedores.buscar_por_id(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //Cargo los datos del cliente
            vendedor.txt_idVendedor.Text = ven.Rows[0]["idVendedor"].ToString();
            vendedor.cmb_tipoDoc.SelectedItem = ven.Rows[0]["idTipoDoc"];
            vendedor.txt_nroDoc.Text = ven.Rows[0]["nroDoc"].ToString();
            vendedor.txt_apellido.Text = ven.Rows[0]["apellido"].ToString();
            vendedor.txt_nombre.Text = ven.Rows[0]["nombre"].ToString();
            vendedor.txt_telefono.Text = ven.Rows[0]["telefono"].ToString();
            vendedor.txt_email.Text = ven.Rows[0]["email"].ToString();
            vendedor.txt_calle.Text = ven.Rows[0]["calle"].ToString();
            vendedor.txt_nro.Text = ven.Rows[0]["nro"].ToString();
            vendedor.cmb_pais.SelectedValue = int.Parse(ven.Rows[0]["idPais"].ToString());
            vendedor.cmb_provincia.SelectedValue = int.Parse(ven.Rows[0]["idProvincia"].ToString());
            vendedor.cmb_localidad.SelectedValue = int.Parse(ven.Rows[0]["idLocalidad"].ToString());
            //cliente.cmb_tipoDoc.SelectedValue = cli.Rows[0]["idTipoDoc"];

            //Abro la pantalla
            vendedor.ShowDialog();
        }
    }
}
