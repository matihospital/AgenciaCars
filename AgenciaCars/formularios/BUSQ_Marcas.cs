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
    public partial class BUSQ_Marcas : Form
    {
        marcas obj_marcas = new marcas();

        public BUSQ_Marcas()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Marcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.MARCAS' table. You can move, or remove it, as needed.
            DataTable tabla = new DataTable();
            tabla = this.obj_marcas.buscarMarcas();

            if (tabla.Rows.Count != 0)
            {
                dataGridView1.DataSource = tabla;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void actualizarGrilla()
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.cLIENTESTableAdapter.Fill(this.agenciaCarsDataSet.CLIENTES);

            DataTable tabla = new DataTable();
            tabla = this.obj_marcas.buscarMarcas();
            dataGridView1.DataSource = tabla;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }
    }
}
