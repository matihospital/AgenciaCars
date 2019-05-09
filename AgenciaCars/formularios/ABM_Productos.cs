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
        modelos obj_modelos = new modelos();
        marcas obj_marcas = new marcas();
        productos obj_productos = new productos();
        paises obj_paises = new paises();
        proveedores obj_proveedores = new proveedores();

        public ABM_Productos()
        {
            InitializeComponent();
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

            //Marcas
            this.cmb_marca.DataSource = this.obj_marcas.buscarMarcas();
            this.cmb_marca.DisplayMember = "descripcion";
            this.cmb_marca.ValueMember = "idMarca";
            
            //Modelos
            this.cmb_modelo.DataSource = this.obj_modelos.ConsultarModelosMarca(this.cmb_marca.SelectedValue.ToString());
            this.cmb_modelo.DisplayMember = "descripcion";
            this.cmb_modelo.ValueMember = "idModelo";

            //Paises
            this.cmb_pais.DataSource = this.obj_paises.Consultar_paises();
            this.cmb_pais.DisplayMember = "descripcion";
            this.cmb_pais.ValueMember = "idPais";

            //Proveedores
            this.cmb_proveedor.DataSource = this.obj_proveedores.buscarProveedores();
            this.cmb_proveedor.DisplayMember = "apellido";
            this.cmb_proveedor.ValueMember = "idProveedor";

            this.ActiveControl = this.txt_descripcion;
            this.cmb_proveedor.SelectedIndex = -1;
        }

        private void blanquear_objetos()
        {
            this.txt_id.Text = "";
            this.txt_descripcion.Text = "";
            this.cmb_marca.SelectedIndex = 0;
            this.cmb_modelo.SelectedIndex = 0;
            this.txt_anio.Text = "";
            this.txt_color.Text = "";
            this.txt_precio.Text = "";
            this.cmb_proveedor.SelectedIndex = -1;
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
            /*foreach (Control c in prod.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("El campo " + c.Text + " no puede estar vacío");
                    c.Focus();
                    return;
                }
            }*/

            if (this.txt_descripcion.Text == "")
            {
                MessageBox.Show("El campo DESCRIPCION no puede estar vacío");
                this.txt_descripcion.Focus();
            }

            else if (this.txt_anio.Text == "")
            {
                MessageBox.Show("El campo AÑO no puede estar vacío");
                this.txt_anio.Focus();
            }

            else if (this.txt_color.Text == "")
            {
                MessageBox.Show("El campo COLOR no puede estar vacío");
                this.txt_color.Focus();
            }

            else if (this.txt_precio.Text == "")
            {
                MessageBox.Show("El campo PRECIO no puede estar vacío");
                this.txt_precio.Focus();
            }

            obj_productos.descripcion = this.txt_descripcion.Text;
            obj_productos.anio = int.Parse(this.txt_anio.Text);
            obj_productos.idModelo = int.Parse(this.cmb_modelo.SelectedValue.ToString());
            obj_productos.color = this.txt_color.Text;
            obj_productos.precio = float.Parse(this.txt_precio.Text);
            obj_productos.idProveedor = int.Parse(this.cmb_proveedor.SelectedValue.ToString());
            obj_productos.idPais = int.Parse(this.cmb_pais.SelectedValue.ToString());
            obj_productos.idEstado = int.Parse(this.cmb_estado.SelectedValue.ToString());

            this.obj_productos.grabarProducto();
            MessageBox.Show("El producto ha sido guardado.");

            blanquear_objetos();
        }

        private void cmb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Modelos
            if (this.cmb_marca.SelectedIndex != 0)
            {
                cmb_modelo.DataSource = null;
                this.cmb_modelo.DataSource = this.obj_modelos.ConsultarModelosMarca(this.cmb_marca.SelectedValue.ToString());
                this.cmb_modelo.DisplayMember = "descripcion";
                this.cmb_modelo.ValueMember = "idModelo";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            blanquear_objetos();
        }
    }
}
