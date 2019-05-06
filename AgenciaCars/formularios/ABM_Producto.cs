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

namespace AgenciaCars.formularios
{
    public partial class ABM_Producto : Form
    {
        public ABM_Producto()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ABM_Producto prod = new ABM_Producto();
            foreach (Control c in prod.Controls)
            {
                if (c is TextBox && c.Text == string.Empty)
                {
                    MessageBox.Show("El campo no puede estar vacío");
                    c.Focus();
                    return;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "";
            this.txt_descripcion.Text = "";
            this.cmb_modelo.Text = "";
            this.txt_año.Text = "";
            this.txt_estado.Text = "";
            this.txt_color.Text = "";
            this.ActiveControl = this.txt_descripcion;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BUSQ_Producto prod = new BUSQ_Producto();
            prod.ShowDialog();
        }

        private void ABM_Producto_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.txt_descripcion;
        }
    }
}
