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
    public partial class BUSQ_Provincias : Form
    {
        public BUSQ_Provincias()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Provincias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.LOCALIDADES' table. You can move, or remove it, as needed.
            this.lOCALIDADESTableAdapter.Fill(this.agenciaCarsDataSet.LOCALIDADES);
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.PROVINCIAS' table. You can move, or remove it, as needed.
            this.pROVINCIASTableAdapter.Fill(this.agenciaCarsDataSet.PROVINCIAS);

        }
    }
}
