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
//lo que en un comentario está entre signo mayor y menor <> es el nombre de un elemento de programación
namespace AgenciaCars
{
    public partial class login : Form
    {
        //se crea la variable local <_id>
        int _id=0;
        //se crea la propiedad pública <_id> para poder obtener desde fuera de la clase el valor de <_id>
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        //se crean las propiedades públicas <usuario> y <password> que son en lasadas con el contenido con el
        //de las cajas de textos <txt_usuario> y <txt_password>
        public string usuario
        {
            get { return this.txt_usuario.Text; }
            set { this.txt_usuario.Text= value; }
        }
        public string password
        {
            get { return this.txt_password.Text; }
            set { this.txt_password.Text = value; }
 
        }
        //esto es le constructor de la clase, que para los formularios es obligatorio y lo pone en forma 
        //automática la herramienta en el momento de crear un formulario
        public login()
        {
            InitializeComponent();
        }
        //eventor clic del botón llamado <cmd_ingresar>,
        //con cracterística de procedimiento (procedure) privado
        private void cmd_ingresar_Click(object sender, EventArgs e)
        {
            //pregunta por el contenido de la caja de texto <txt_usuiaro> si es vacío
            if (this.txt_usuario.Text =="")
            {
                //envía mensaje a pantalla
                MessageBox.Show("El usuario no está cargado");
                //enfoca la caja de texto <txt_usuario>
                this.txt_usuario.Focus();
                //corta la ejecución de procedimiento
                return;
            }
            if (this.txt_password.Text=="")
            {
                MessageBox.Show("El password está vacío");
                this.txt_password.Focus();
                return;
            }
            //instancia el objeto <validar_usuario> del tipo de la clase <users>
            users validar_usuario = new users();
            //crea objeto <tabla> del tipo DataTable 
            DataTable tabla = new DataTable();
            //ejecuta la función <consulta_login> dentro del objeto <validar_usuario>,
            //el resultado de la ejecución de la función se aloja en <tabla>
            tabla = validar_usuario.consulta_login(this.txt_usuario.Text.Trim(), this.txt_password.Text.Trim());
            //se pregunta si <tabla> tiene una unica fila
            if (tabla.Rows.Count==1)
            {
                //se obtiene el contenido de la primera fila y prmiera columna de <tabla>
                //las tablas y arreglos (vectores y matrices) tiene base de indice cero (0),
                //el primer elemento se indica con cero (0)
                this._id = int.Parse(tabla.Rows[0][0].ToString());
                //se cierra el objeto actual (formulario login)
                this.Close();
            }
            else
            {
                //se envía mensaje a pantalla
                MessageBox.Show("Login fallido");
            }
            
        }
        //evento que se dispara cuando se cierra el formulario
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se utiliza <MessageBox> como una funcion que devuelve un valor 
            //de <Yes> o <No> y es comparado con un valor de <Yes>
            if (MessageBox.Show("Está seguro que desea abandonar el formulario?"
                ,"Importante", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {
                //por verdadero se asigna al parametro de entrada el valor de falso
                //para que el programa finalice
                e.Cancel = false ;
            }
        }

    }
}
