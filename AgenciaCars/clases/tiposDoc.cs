using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class tiposDoc
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable Consultar_tiposDoc(){
            return _BD.consulta("SELECT * FROM TIPOS_DOCUMENTOS");
        }
    }
}
