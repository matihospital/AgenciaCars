using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AgenciaCars.clases
{
    class perfiles
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable Recuperar_perfiles()
        {
            return _BD.consulta("SELECT * FROM PERFILES");
        }
    }
}
