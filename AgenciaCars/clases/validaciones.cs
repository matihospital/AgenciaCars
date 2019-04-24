using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.clases;

namespace AgenciaCars.clases
{
    class validaciones
    {
        public enum estado_validacion { correcta, erronea}

        public estado_validacion validar_campos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    //VER QUE HIZO EN TEXTBOX01.CS
                    if (item.Text == "")
                    {
                        MessageBox.Show("El campo " + item.Name + " no puede estar vacío");
                        return estado_validacion.erronea;
                    }
                }
            }
            return estado_validacion.correcta;
        }
    }
}
