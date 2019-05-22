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
    public partial class BUSQ_Ventas : Form
    {
        facturas obj_facturas = new facturas();

        public BUSQ_Ventas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Ventas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = this.obj_facturas.buscarFacturasVenta();
            dataGridView1.DataSource = tabla;
        }

    }
}
