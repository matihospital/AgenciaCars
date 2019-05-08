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
    public partial class BUSQ_Productos : Form
    {
        productos obj_productos = new productos();

        public BUSQ_Productos()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir ABM
            ABM_Productos frm = new formularios.ABM_Productos();
            frm.ShowDialog();
        }

        private void BUSQ_Productos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.PRODUCTOS' table. You can move, or remove it, as needed.
            this.pRODUCTOSTableAdapter.Fill(this.agenciaCarsDataSet.PRODUCTOS);

            DataTable tabla = new DataTable();
            tabla = this.obj_productos.buscarProductos();

            if (tabla.Rows.Count != 0)
            {
                gridProductos.DataSource = tabla;
            }
        }
    }
}
