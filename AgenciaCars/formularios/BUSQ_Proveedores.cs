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
    public partial class BUSQ_Proveedores: Form
    {
        proveedores obj_proveedores = new proveedores();

        public BUSQ_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de busqueda
            ABM_Proveedores frm = new formularios.ABM_Proveedores();
            frm.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Proveedores_Load(object sender, EventArgs e)
        {
            actualizarGrilla();
            this.txt_busqueda.Text = "";
        }

        private void actualizarGrilla()
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.pROVEEDORESTableAdapter.Fill(this.agenciaCarsDataSet.PROVEEDORES);
            DataTable tabla = new DataTable();
            tabla = this.obj_proveedores.buscarProveedores();
            dataGridView1.DataSource = tabla;

        }
    
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
            this.txt_busqueda.Text = "";
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
                DataTable tabla = new DataTable();

                //Busco segun lo seleccionado
                if (this.ck_id.Checked)
                {
                    tabla = this.obj_proveedores.buscarPorParametro("idProveedor", this.txt_busqueda.Text);
                }
                else if (this.ck_nrodoc.Checked)
                {
                    tabla = this.obj_proveedores.buscarPorParametro("nroDoc", this.txt_busqueda.Text);
                }
                else if (this.ck_apellido.Checked)
                {
                    tabla = this.obj_proveedores.buscarSiContiene("apellido", this.txt_busqueda.Text);
                }
                else if (this.ck_nombre.Checked)
                {
                    tabla = this.obj_proveedores.buscarSiContiene("nombre", this.txt_busqueda.Text);
                }
                else { return; }

                
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos");
                    this.txt_busqueda.Focus();
                    return;
                }
                dataGridView1.DataSource = tabla;

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //Busco los datos del proveedor
            DataTable prv = new DataTable();
            prv = this.obj_proveedores.buscar_por_id(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            ABM_Proveedores proveedor = new formularios.ABM_Proveedores(prv.Rows[0]["idTipoDoc"].ToString(),
                                                                        prv.Rows[0]["idPais"].ToString(),
                                                                        prv.Rows[0]["idProvincia"].ToString(),
                                                                        prv.Rows[0]["idLocalidad"].ToString());
          //Cargo los datos del proveedor
            proveedor.txt_idProveedor.Text = prv.Rows[0]["idProveedor"].ToString();
            proveedor.cmb_tipoDoc.SelectedValue = int.Parse(prv.Rows[0]["idTipoDoc"].ToString());
            proveedor.txt_nroDoc.Text = prv.Rows[0]["nroDoc"].ToString();
            proveedor.txt_apellido.Text = prv.Rows[0]["apellido"].ToString();
            proveedor.txt_nombre.Text = prv.Rows[0]["nombre"].ToString();
            proveedor.txt_telefono.Text = prv.Rows[0]["telefono"].ToString();
            proveedor.txt_email.Text = prv.Rows[0]["email"].ToString();
            proveedor.txt_calle.Text = prv.Rows[0]["calle"].ToString();
            proveedor.txt_nro.Text = prv.Rows[0]["nro"].ToString();
            proveedor.cmb_pais.SelectedValue = int.Parse(prv.Rows[0]["idPais"].ToString());
            proveedor.cmb_provincia.SelectedValue = int.Parse(prv.Rows[0]["idProvincia"].ToString());
            proveedor.cmb_localidad.SelectedValue = int.Parse(prv.Rows[0]["idLocalidad"].ToString());

            //Deshabilito campos que no puede usar
            proveedor.cmb_tipoDoc.Enabled = false;
            proveedor.txt_nroDoc.Enabled = false;
            proveedor.btn_cancelar.Enabled = false;

            //Abro la pantalla
            proveedor.ShowDialog();
        }
    }
}
