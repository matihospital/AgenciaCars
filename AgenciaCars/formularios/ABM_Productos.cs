using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.formularios;
using AgenciaCars.clases;

namespace AgenciaCars.formularios
{
    public partial class ABM_Productos : Form
    {
        estados obj_estados = new estados();
        productos obj_productos = new productos();

        public ABM_Productos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            blanquear_objetos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BUSQ_Productos prod = new BUSQ_Productos();
            prod.ShowDialog();
        }

        private void ABM_Producto_Load(object sender, EventArgs e)
        {
            //Estados
            this.cmb_estado.DataSource = this.obj_estados.Consultar_estados();
            this.cmb_estado.DisplayMember = "descripcion";
            this.cmb_estado.ValueMember = "idEstado";

            this.ActiveControl = this.txt_descripcion;
        }

        private void blanquear_objetos()
        {
            this.txt_id.Text = "";
            this.txt_descripcion.Text = "";
            this.cmb_modelo.SelectedIndex = -1;
            this.txt_anio.Text = "";
            this.cmb_estado.SelectedIndex = 0;
            this.txt_descripcion.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Validar que no haya campos vacios
            ABM_Productos prod = new ABM_Productos();
            foreach (Control c in prod.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("El campo " + c.Text + " no puede estar vacío");
                    c.Focus();
                    return;
                }
            }

            obj_productos.idProducto = int.Parse(this.txt_id.Text);
            obj_productos.descripcion = this.txt_descripcion.Text;
            obj_productos.anio = int.Parse(this.txt_anio.Text);
            obj_productos.idModelo = int.Parse(this.cmb_modelo.SelectedValue.ToString());
            obj_productos.color = this.txt_color.Text;
            obj_productos.precio = float.Parse(this.txt_precio.Text);
            obj_productos.idProveedor = int.Parse(this.cmb_proveedor.SelectedValue.ToString());
            obj_productos.estado = int.Parse(this.cmb_estado.SelectedValue.ToString());

            this.obj_productos.grabarProducto();
            MessageBox.Show("El producto ha sido guardado.");

            blanquear_objetos();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            blanquear_objetos();
        }
    }
}
