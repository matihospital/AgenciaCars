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

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_modelo.Text = "";
            this.txt_año.Text = "";
            this.txt_estado.Text = "";
            this.txt_color.Text = "";
            this.txt_descripcion.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BUSQ_Producto prod = new BUSQ_Producto();
            prod.ShowDialog();
        }
    }
}
