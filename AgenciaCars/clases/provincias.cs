using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class provincias
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable Consultar_provincias(){
            return _BD.consulta(@"SELECT pro.idProvincia as Id,
                                         pro.descripcion as Provincia
                                  FROM PROVINCIAS as pro");
        }

        public DataTable ConsultarProvinciasPais(String idPais)
        {
            return _BD.consulta("SELECT * FROM PROVINCIAS WHERE idPais=" + idPais );
        }
    }
}
