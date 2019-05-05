using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class paises
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable Consultar_paises(){
            return _BD.consulta("SELECT * FROM PAISES");
        }
    }
}
