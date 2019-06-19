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
    public partial class ABM_Proveedores : Form
    {
        tiposDoc obj_tiposDoc = new tiposDoc();
        paises obj_paises = new paises();
        provincias obj_provincias = new provincias();
        localidades obj_localidades = new localidades();
        proveedores obj_provedores = new proveedores();
    
        public ABM_Proveedores()
        {
            InitializeComponent();
        }

        private void ABM_Proveedores_Load(object sender, EventArgs e)
        {
            //Tipos de Documento
            this.cmb_tipoDoc.DataSource = this.obj_tiposDoc.Consultar_tiposDoc();
            this.cmb_tipoDoc.DisplayMember = "descripcion";
            this.cmb_tipoDoc.ValueMember = "idTipoDoc";

            //Paises
            this.cmb_pais.DataSource = this.obj_paises.Consultar_paises();
            this.cmb_pais.DisplayMember = "Pais";
            this.cmb_pais.ValueMember = "Id";
            //Provincias
            this.cmb_provincia.DataSource = this.obj_provincias.Consultar_provincias();
            this.cmb_provincia.DisplayMember = "Provincia";
            this.cmb_provincia.ValueMember = "Id";
            //Localidades
            this.cmb_localidad.DataSource = this.obj_localidades.Consultar_localidades();
            this.cmb_localidad.DisplayMember = "Localidad";
            this.cmb_localidad.ValueMember = "Id";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            blanquear_objetos();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Validar que no haya campos vacios
            ABM_Proveedores proveedores = new ABM_Proveedores();
            /*foreach (Control c in proveedores.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("El campo " + c.Name + " no puede estar vacío");
                    c.Focus();
                    return;
                }
            }*/

            if (this.txt_nroDoc.Text == "")
            {
                MessageBox.Show("El campo NRO. DOCUMENTO no puede estar vacío");
                this.txt_nroDoc.Focus();
            }

            else if (this.txt_apellido.Text == "")
            {
                MessageBox.Show("El campo APELLIDO no puede estar vacío");
                this.txt_apellido.Focus();
            }

            else if (this.txt_nombre.Text == "")
            {
                MessageBox.Show("El campo NOMBRE no puede estar vacío");
                this.txt_nombre.Focus();
            }

            else if (this.label_15.Text == "")
            {
                MessageBox.Show("El campo TELEFONO no puede estar vacío");
                this.label_15.Focus();
            }

            else if (this.txt_email.Text == "")
            {
                MessageBox.Show("El campo EMAIL no puede estar vacío");
                this.txt_email.Focus();
            }

            else if (this.txt_calle.Text == "")
            {
                MessageBox.Show("El campo CALLE no puede estar vacío");
                this.txt_calle.Focus();
            }

            else if (this.txt_nro.Text == "")
            {
                MessageBox.Show("El campo NRO no puede estar vacío");
                this.txt_nro.Focus();
            }


            //validar que no exista el cliente por tipo y nro de doc

            //se transfieren los cotenidos de los objetos a las propiedades del 
            //objeto negocio "obj_usuario" para que esté enterado de los datos
            //que se utilizarán en las siguientes acciones
            obj_provedores.idTipoDoc = int.Parse(this.cmb_tipoDoc.SelectedValue.ToString());
            obj_provedores.nroDoc = int.Parse(this.txt_nroDoc.Text);
            obj_provedores.apellido = this.txt_apellido.Text;
            obj_provedores.nombre = this.txt_nombre.Text;
            obj_provedores.calle = this.txt_calle.Text;
            obj_provedores.nro = int.Parse(this.txt_nro.Text);
            obj_provedores.telefono = this.txt_telefono.Text;
            obj_provedores.email = this.txt_email.Text;
            obj_provedores.idLocalidad = int.Parse(this.cmb_localidad.SelectedValue.ToString());

            this.obj_provedores.grabarProveedor();
            MessageBox.Show("Proveedor guardado correctamente.");

            blanquear_objetos();
        }

        private void blanquear_objetos()
        {
            this.txt_idProveedor.Text = "";
            this.cmb_tipoDoc.SelectedIndex = -1;
            this.txt_nroDoc.Text = "";
            this.txt_apellido.Text = "";
            this.txt_nombre.Text = "";
            this.txt_telefono.Text = "";
            this.txt_email.Text = "";
            this.txt_calle.Text = "";
            this.txt_nro.Text = "";
            this.cmb_localidad.SelectedIndex = 0;
            this.cmb_provincia.SelectedIndex = 0;
            this.cmb_pais.SelectedIndex = 0;
            this.txt_nroDoc.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Localidades
            if (this.cmb_provincia.SelectedIndex != 0)
            {
                cmb_localidad.DataSource = null;
                this.cmb_localidad.DataSource = this.obj_localidades.ConsultarLocalidadesProvincia(this.cmb_provincia.SelectedValue.ToString());
                this.cmb_localidad.DisplayMember = "Localidad";
                this.cmb_localidad.ValueMember = "Id";
            }
        }

        private void cmb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Provincias
            if (this.cmb_pais.SelectedIndex != 0)
            {
                cmb_provincia.DataSource = null;
                this.cmb_provincia.DataSource = this.obj_provincias.ConsultarProvinciasPais(this.cmb_pais.SelectedValue.ToString());
                this.cmb_provincia.DisplayMember = "Provincia";
                this.cmb_provincia.ValueMember = "Id";

            }
        }


    }
}
