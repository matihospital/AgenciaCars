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
    public partial class BUSQ_Compras : Form
    {
        facturas obj_facturas = new facturas();

        public BUSQ_Compras()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Compras_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_facturas.buscarFacturasCompra();
            dataGridView1.DataSource = tabla;
        }

    }
}
