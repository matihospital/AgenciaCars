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
    public partial class BUSQ_Localidades : Form
    {
        localidades obj_localidades = new localidades();
        
        public BUSQ_Localidades()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Localidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.LOCALIDADES' table. You can move, or remove it, as needed.
            //this.lOCALIDADESTableAdapter.Fill(this.agenciaCarsDataSet.LOCALIDADES);
            DataTable tabla = new DataTable();
            tabla = this.obj_localidades.Consultar_localidades();
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
