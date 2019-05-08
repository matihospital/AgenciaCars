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
    public partial class ABM_Usuarios : Form
    {
        tiposDoc obj_estados = new tiposDoc();
        perfiles obj_perfiles = new perfiles();
        users obj_usuarios = new users();

        public ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            /*this.cmb_estado.DataSource = this.obj_estados.Consultar_tiposDoc();
            this.cmb_estado.DisplayMember = "descripcion";
            this.cmb_estado.ValueMember = "idEstado";*/

            /*this.cmb_perfil.DataSource = this.obj_perfiles.Consultar_perfiles();
            this.cmb_perfil.DisplayMember = "descripcion";
            this.cmb_perfil.ValueMember = "idPerfil";
            this.cmb_estado.SelectedIndex = -1;*/
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            obj_usuarios.n_usuario = this.txt_nombre.Text;
            obj_usuarios.n_password = this.txt_password.Text;
            obj_usuarios.n_email = this.txt_email.Text;
            obj_usuarios.n_perfil = int.Parse(this.cmb_perfil.SelectedValue.ToString());
            obj_usuarios.n_estado = int.Parse(this.cmb_estado.SelectedValue.ToString());

            if (this.obj_usuarios.validar_datos() == false) {
                MessageBox.Show("Error. Revise los datos ingresados.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }


    }
}
