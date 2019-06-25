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
    public partial class BUSQ_Clientes : Form
    {
        clientes obj_clientes = new clientes();

        public BUSQ_Clientes()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir ABM
            ABM_Clientes frm = new formularios.ABM_Clientes();
            frm.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Clientes_Load(object sender, EventArgs e)
        {
           actualizarGrilla();
           this.txt_busqueda.Text = "";
        }

        public void actualizarGrilla()
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.cLIENTESTableAdapter.Fill(this.agenciaCarsDataSet.CLIENTES);

            DataTable tabla = new DataTable();
            tabla = this.obj_clientes.buscarClientes();
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
                    tabla = this.obj_clientes.buscarPorParametro("idCliente", this.txt_busqueda.Text);
                }
                else if (this.ck_nroDoc.Checked)
                {
                    tabla = this.obj_clientes.buscarPorParametro("nroDoc", this.txt_busqueda.Text);
                }
                else if (this.ck_apellido.Checked)
                {
                    tabla = this.obj_clientes.buscarSiContiene("apellido", this.txt_busqueda.Text);
                }
                else if (this.ck_nombre.Checked)
                {
                    tabla = this.obj_clientes.buscarSiContiene("nombre", this.txt_busqueda.Text);
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
            
            //Busco los datos del cliente
            DataTable cli = new DataTable();
            cli = this.obj_clientes.buscar_por_id(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            ABM_Clientes cliente = new formularios.ABM_Clientes(cli.Rows[0]["idTipoDoc"].ToString(),
                                                                cli.Rows[0]["idPais"].ToString(),
                                                                cli.Rows[0]["idProvincia"].ToString(),
                                                                cli.Rows[0]["idLocalidad"].ToString());

            //Cargo los datos del cliente
            cliente.txt_idCliente.Text = cli.Rows[0]["idCliente"].ToString();
            cliente.cmb_tipoDoc.SelectedValue = cli.Rows[0]["idTipoDoc"].ToString();
            cliente.txt_nroDoc.Text = cli.Rows[0]["nroDoc"].ToString();
            cliente.txt_apellido.Text = cli.Rows[0]["apellido"].ToString();
            cliente.txt_nombre.Text = cli.Rows[0]["nombre"].ToString();
            cliente.txt_telefono.Text = cli.Rows[0]["telefono"].ToString();
            cliente.txt_email.Text = cli.Rows[0]["email"].ToString();
            cliente.txt_calle.Text = cli.Rows[0]["calle"].ToString();
            cliente.txt_nro.Text = cli.Rows[0]["nro"].ToString();
            cliente.cmb_pais.SelectedValue = cli.Rows[0]["idPais"].ToString();
            cliente.cmb_provincia.SelectedValue = cli.Rows[0]["idProvincia"].ToString();
            cliente.cmb_localidad.SelectedValue = cli.Rows[0]["idLocalidad"].ToString();
            
            //Deshabilito campos que no puede usar
            cliente.cmb_tipoDoc.Enabled = false;
            cliente.txt_nroDoc.Enabled = false;
            cliente.btn_cancelar.Enabled = false;

            //Abro la pantalla
            cliente.ShowDialog();


        }
    }
}
