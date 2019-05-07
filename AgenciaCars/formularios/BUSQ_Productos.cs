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
    public partial class BUSQ_Productos : Form
    {
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
    }
}
