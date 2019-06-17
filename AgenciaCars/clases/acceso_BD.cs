using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AgenciaCars.clases
{
    class acceso_BD
    {

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string cadena_conexion = "Provider=SQLNCLI11;Data Source=MATI\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=AgenciaCars;";
        //string cadena_conexion = "Provider=SQLNCLI11;Data Source=NBDELLPABLO;Integrated Security=SSPI;Initial Catalog=AgenciaCars";
        //string cadena_conexion = "Provider=SQLNCLI11;Data Source=LAPTOP-L2T9FM0J;Integrated Security=SSPI;Initial Catalog=AgenciaCars";

        public enum resultado_acceso { error, correcto }
        public enum tipo_conexion { simple, transaccion }
        resultado_acceso control_transaccion = resultado_acceso.correcto;
        tipo_conexion analisis_tipo_transaccion = tipo_conexion.simple;
        OleDbTransaction transaccion;
 
        private void conectar()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.ConnectionString = cadena_conexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = System.Data.CommandType.Text;
                if (analisis_tipo_transaccion == tipo_conexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadUncommitted);
                    cmd.Transaction = transaccion;
                }
            }
        }

        private void cerrar()
        {
            if (analisis_tipo_transaccion == tipo_conexion.simple)
            {
                conexion.Close();
            }

        }

        public DataTable consulta(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return tabla;
                throw;
            }
            cerrar();
            return tabla;
        }

        public void grabar_modificar(string comando)
        {
            //se conecta con la base de datos
            conectar();
            cmd.CommandText = comando;
            cmd.ExecuteNonQuery();
            //se cierra la conexión 
            cerrar();
        }

        private string formatear_dato(string dato, TextBox01.tipo_dato tipo)
        {
            switch (tipo)
            {
                case TextBox01.tipo_dato.texto:
                    return "'" + dato.Trim() + "'";
                //break;
                case TextBox01.tipo_dato.numero:
                    return dato.Trim();
                //break;
            }
            return dato.Trim();
        }

        public void iniciar_transaccion()
        {
            analisis_tipo_transaccion = tipo_conexion.transaccion;
            control_transaccion = resultado_acceso.correcto;
        }

        public void cerrar_transaccion()
        {
            if (analisis_tipo_transaccion == tipo_conexion.simple)
                return;
            if (control_transaccion == resultado_acceso.correcto)
            {
                transaccion.Commit();
                MessageBox.Show("La Factura se grabó correctamente");
            }
            else
            {
                transaccion.Rollback();
                MessageBox.Show("No se pudo grabar la factura");
            }
            analisis_tipo_transaccion = tipo_conexion.simple;
            cerrar();
        }

        public resultado_acceso insert_update_delete(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return resultado_acceso.error;
            }
            cerrar();
            return resultado_acceso.correcto;
        }
    }
}
