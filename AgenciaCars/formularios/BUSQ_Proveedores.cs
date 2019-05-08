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
    public partial class BUSQ_Proveedores: Form
    {
        public BUSQ_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir pantalla de busqueda
            ABM_Proveedores frm = new formularios.ABM_Proveedores();
            frm.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSQ_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.PROVEEDORES' table. You can move, or remove it, as needed.
            this.pROVEEDORESTableAdapter.Fill(this.agenciaCarsDataSet.PROVEEDORES);

        }

        private void proveedoresToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pROVEEDORESTableAdapter.Proveedores(this.agenciaCarsDataSet.PROVEEDORES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
