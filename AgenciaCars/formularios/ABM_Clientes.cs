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
    public partial class ABM_Clientes : Form
    {
        public ABM_Clientes()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.txt_idCliente.Text = "";
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

    }
}
