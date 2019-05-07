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
    public partial class BUSQ_Usuarios : Form
    {
        public BUSQ_Usuarios()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //Abrir ABM
            ABM_Usuarios frm = new formularios.ABM_Usuarios();
            frm.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
