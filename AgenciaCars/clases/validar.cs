using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaCars.clases;

namespace AgenciaCars.clases
{
    class validar
    {
        //Se declara una enumeración para explicitar el valor devuelto en el analisis
        //de validación. Entonces estado de validación permite dos valores: correcto, erroneo.
        public enum estado_validacion { correcta, erronea }
        //Se define una función para realizar la validación básica de contenido de objetos del
        //formulario, donde se valora si está vacio si es un TextBox01 o si esta sin selección
        //si es un ComboBox01.
        //Esta función recibe como parámetro todos los objetos de un formulario. 
        //Para que esta función realice su tarea correctamente, tiene que trabajar con las 
        //clases sistematizadas TextBox01 y ComboBox01, pues utilizará las propiedades definidas
        //en ellas para analizar si debe hacer o no validación. Los demás objetos no serán 
        //tratados. 
        public estado_validacion validar_form(Control.ControlCollection controles)
        {
            //foreach recorre todos los objetos de un formulario que ingresaron por 
            //parámetro de entrada -controles-
            foreach (Control item in controles)
            {
                //preguta si el objeto actual -item- es del tipo TextBox01
                if (item.GetType().Name == "TextBox01")
                {
                    //establece si el objeto es validable o no
                    if (((TextBox01)item)._validable == true)
                    {
                        //consulta si el objeto TextBox01 está vacio
                        if (item.Text == "")
                        {
                            //en caso de estar vacio, emite el mensaje de error que el 
                            //mismo objeto trae en su propidad  -_mensaje_error-
                            MessageBox.Show(((TextBox01)item)._mensaje_error);
                            //enfoca el objeto para que quede señalado en el formulario
                            ((TextBox01)item).Focus();
                            //corta el analisis y devuelve estado_validación -erronea-
                            return estado_validacion.erronea;
                        }
                    }
                }
                //para el ComboBox01 realiza el mismo analisis que para el TextBox01
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item)._validable == true)
                    {
                        if (((ComboBox01)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBox01)item)._mensaje_error);
                            ((ComboBox01)item).Focus();
                            return estado_validacion.erronea;
                        }
                    }
                }
            }
            //si cuando completa el ciclo el foreach no ingreso por ningúna pregunta de
            //validación, entonces termina la función saliendo por aquí y devolviendo
            //estado validación -correcta-
            return estado_validacion.correcta;
        }
    }
}
