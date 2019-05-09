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
        proveedores obj_provedores = new proveedores();

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

        }

        private void actualizarGrilla()
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.pROVEEDORESTableAdapter.Fill(this.agenciaCarsDataSet.PROVEEDORES);
            DataTable tabla = new DataTable();
            tabla = this.obj_provedores.buscarProveedores();
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
                    tabla = this.obj_provedores.buscarPorParametro("idProveedor", this.txt_busqueda.Text);
                }
                else if (this.ck_nrodoc.Checked)
                {
                    tabla = this.obj_provedores.buscarPorParametro("nroDoc", this.txt_busqueda.Text);
                }
                else if (this.ck_apellido.Checked)
                {
                    tabla = this.obj_provedores.buscarSiContiene("apellido", this.txt_busqueda.Text);
                }
                else if (this.ck_nombre.Checked)
                {
                    tabla = this.obj_provedores.buscarSiContiene("nombre", this.txt_busqueda.Text);
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
    }
}
