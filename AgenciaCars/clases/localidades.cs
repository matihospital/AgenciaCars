using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class localidades
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable Consultar_localidades(){
            return _BD.consulta(@"SELECT loc.idLocalidad as Id,
                                         loc.descripcion as Localidad,
                                         pro.descripcion as Provincia 
                                  FROM LOCALIDADES as loc, 
                                       PROVINCIAS as pro
                                  WHERE loc.idProvincia = pro.idProvincia");
        }

        public DataTable ConsultarLocalidadesProvincia(String idProvincia)
        {
            return _BD.consulta(@"SELECT loc.idLocalidad as Id,
                                         loc.descripcion as Localidad 
                                  FROM LOCALIDADES as loc WHERE loc.idProvincia=" + idProvincia);
        }
    }
}
