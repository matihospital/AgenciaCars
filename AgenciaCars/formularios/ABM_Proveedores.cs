using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaCars.formularios
{
    public partial class ABM_Proveedores : Form
    {
        public ABM_Proveedores()
        {
            InitializeComponent();
        }

        private void ABM_Proveedores_Load(object sender, EventArgs e)
        {
            //HASTA QUE TENGAMOS LA BASE
            this.cmb_tipoDoc.Items.Add("DNI");
            this.cmb_tipoDoc.Items.Add("LE");
            this.cmb_tipoDoc.Items.Add("Pasaporte");
            this.cmb_tipoDoc.SelectedIndex = 0;

            this.cmb_pais.Items.Add("Argentina");
            this.cmb_pais.Items.Add("Brasil");
            this.cmb_pais.Items.Add("Uruguay");
            this.cmb_pais.SelectedIndex = 0;

            this.cmb_provincia.Items.Add("Cordoba");
            this.cmb_provincia.Items.Add("Buenos Aires");
            this.cmb_provincia.Items.Add("Salta");
            this.cmb_provincia.SelectedIndex = 0;

            this.cmb_localidad.Items.Add("Cordoba");
            this.cmb_localidad.Items.Add("La Calera");
            this.cmb_localidad.Items.Add("Malagueño");
            this.cmb_localidad.SelectedIndex = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.txt_idProveedor.Text = "";
            this.cmb_tipoDoc.SelectedIndex = -1;
            this.txt_nroDoc.Text = "";
            this.txt_apellido.Text = "";
            this.txt_nombre.Text = "";
            this.txt_calle.Text = "";
            this.txt_nro.Text = "";   
            this.cmb_localidad.SelectedIndex = -1;
            this.cmb_provincia.SelectedIndex = -1;
            this.cmb_pais.SelectedIndex = -1;
            this.txt_nroDoc.Focus();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Validar que no haya campos vacios (VER DE HACER UN FOR POR CADA CAMPO)

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
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de busqueda
            BUSQ_Proveedores frm = new formularios.BUSQ_Proveedores();
            frm.ShowDialog();
        }

    }
}
