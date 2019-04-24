using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.formularios;

namespace AgenciaCars
{
    public partial class Escritorio : Form
    {
        //se definen dos variables locales a la clase (escritorio) del tipo string
        //_usuario y _password, también una variable del tipo int (entera)
        //_id. Estás variables son el respaldo físico para guardar el resultado
        //de la acción positiva (login correcto) del login.
        string _usuario;
        string _password;
        int _id;
        //Respecto de propiedades públicas: vea documentación adicional en archivo comprimido
        //con explicaciones por cada elemento de programación.
        //se define la propiedad pública id, que es el mecanismo de acceso externo al
        //valor alojado en la variable _id
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        //se define la propiedad pública usuario, que es el mecanismo de acceso externo al
        //valor alojado en la variable _usuario
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        //se define la propiedad pública password, que es el mecanismo de acceso externo al
        //valor alojado en la variable _password
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Escritorio()
        {
            InitializeComponent();
        }
        //evento load del formulario escritorio. Este evento es el que se dispara cuando el formulario
        //se pone en funciones
        private void Escritorio_Load(object sender, EventArgs e)
        {

            //ESTO NO LO BORRO DESPUES VEMOS SI LE PONEMOS UN LOGIN O NO

            //se instancia el formulario <login> como objeto con el nombre de <frm_login> dentro de escritorio.
            //para instanciar un objeto siempre es necesario utilizar le comando <new>
            //login frm_login = new login();
            ////se pide que se despliegue el formulario <frm_login>
            ////ShowDialog: despliega el formulario y le transfiere el control de proceso al mismo
            //frm_login.ShowDialog();
            ////se realizar una pregunta por el valor de la propiedada publica id dentro de frm_login, si es 
            ////igual a cero (0)
            //if (frm_login.id==0)
            //{
            //    //se envía mensaje a pantalla
            //    MessageBox.Show("La información de login no es suficiente");
            //    //se mata el formulario frm_login con Dispose
            //    frm_login.Dispose();
            //    //se cierra el formulario escritorio con Close
            //    this.Close();
            //}
            //else
            //{
            //    //envia mensaje a pantalla
            //    MessageBox.Show("Usuario: " + frm_login.usuario + '\n'
            //        + "Password: " + frm_login.password+'\n'
            //        + "id usuario:"+frm_login.id.ToString());
            //    //recupera el valor de las propiedades publicas: password, usuario, id del formulario 
            //    //frm_login a las variables locales del mismo nombre con prefijo guion bajo.
            //    this._password = frm_login.password;
            //    this._usuario = frm_login.usuario;
            //    this._id = frm_login.id;
            //}
            ////elimina el formulario frm_login con el comando Dispose
            //frm_login.Dispose();


        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aBMDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_ABM_Usuarios frm = new formularios.frm_ABM_Usuarios();
            //frm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Clientes frm = new formularios.ABM_Clientes();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Proveedores frm = new formularios.ABM_Proveedores();
            frm.ShowDialog();
        }

    }
}
