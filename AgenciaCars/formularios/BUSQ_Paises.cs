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
    public partial class BUSQ_Paises : Form
    {
        paises obj_paises = new paises();

        public BUSQ_Paises()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Paises_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.PAISES' table. You can move, or remove it, as needed.
            //this.pAISESTableAdapter.Fill(this.agenciaCarsDataSet.PAISES);
            DataTable tabla = new DataTable();
            tabla = this.obj_paises.Consultar_paises();
            dataGridView1.DataSource = tabla;

        }

    }
}
