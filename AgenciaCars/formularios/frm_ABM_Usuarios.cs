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
    public partial class frm_ABM_Usuarios : Form
    {
        tiposDoc obj_estados = new tiposDoc();
        perfiles obj_perfiles = new perfiles();
        users obj_usuarios = new users();

        public frm_ABM_Usuarios()
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
            this.cmb_estado.DisplayMember = "n_estado";
            this.cmb_estado.ValueMember = "id_estado";

            this.cmb_perfil.DataSource = this.obj_perfiles.Consultar_tiposDoc();
            this.cmb_perfil.DisplayMember = "n_perfil";
            this.cmb_perfil.ValueMember = "id_perfil";
            this.cmb_estado.SelectedIndex = -1;*/
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.txt_email.Text = "";
            this.txt_id.Text = "";
            this.txt_nombre.Text = "";
            this.txt_password.Text = "";
            this.cmb_perfil.SelectedIndex = -1;
            this.cmb_estado.SelectedIndex = -1;
            this.txt_nombre.Focus();
            this.btn_guardar.Enabled = true;
            this.btn_actualizar.Enabled = false;
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


    }
}
