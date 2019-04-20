using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;
using System.Windows.Forms;
//Esta clase en parte de la programación en capas, y es la capa intermedia llamada habitualmente negocio
namespace AgenciaCars.clases
{
    class users
    {
        //se instancia un objeto <_BD> del tipo <acceso_BD>
        acceso_BD _BD = new acceso_BD();
        string _n_usuario, _password, _email;
        int _perfil, _estado = -1;
        //se define una función pública <consulta_login> que recibe dos parámetros de entrada
        //que permite evaluar en la base de datos en la tabla <users> si la combinación de 
        //<usuario> y <pssw> existen, en caso de exitir devuelte una tabla con contenido, por lo
        //contrario devuelve una tabla vacía
        public DataTable consulta_login(string usuario, string pssw)
        {
            //se define una variable local a la función <sqltxt> del tipo <string> donde en el 
            //momento de su creación se le asigan su contenido, que es el comando SELECT  
            //necesario para poder establecer la veracidad del usuario.
            string sqltxt = @"SELECT * FROM users 
                             WHERE n_usuario = '" + usuario+"'"
                             + " AND password = '" + pssw+"'";

            //aquí dos acciones. 1)ejecuta el SQL atravéz del objeto <_BD> utilizando la función
            //<consulta> pasando por parámentro de la función el comando SQL, esta función devuelve una tabla.
            //2)Devuelve con el comando <return> a travéz de la función <consulta_login> el resultado 
            //del SQL.
            return _BD.consulta(sqltxt);
        }

        public string n_usuario { get{ return this._n_usuario; }
                                  set { this._n_usuario = value; }
        }

        public string n_password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        public string n_email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        public int n_perfil
        {
            get { return this._perfil; }
            set { this._perfil = value; }
        }

        public int n_estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }

        public Boolean validar_datos()
        {
            if (this._n_usuario == "")
            {
                MessageBox.Show("El usuario está vacío");
                return false;
            }else if (this._password == ""){
                MessageBox.Show("La contraseña está vacía");
                return false;
            }
            else if (this._email == "")
            {
                MessageBox.Show("El email está vacío");
                return false;
            }
            else if (this._perfil == -1)
            {
                MessageBox.Show("El perfil está vacío");
                return false;
            }
            else if (this._estado == -1)
            {
                MessageBox.Show("El estado está vacío");
                return false;
            }
            return true;
        }
    }
}
