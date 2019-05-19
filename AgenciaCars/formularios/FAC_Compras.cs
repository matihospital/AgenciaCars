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
    public partial class FAC_Compras : Form
    {
        public FAC_Compras()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agenciaCarsDataSet.FACTURASDET' table. You can move, or remove it, as needed.
            //this.fACTURASDETTableAdapter.Fill(this.agenciaCarsDataSet.FACTURASDET);

            this.tipoComprobante.Text = "FACTURA DE COMPRA";
            this.fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

    }
}
