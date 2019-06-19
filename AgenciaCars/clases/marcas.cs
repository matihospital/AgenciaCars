using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class marcas
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable buscarMarcas(){
            return _BD.consulta(@"SELECT mar.idMarca as Id,
                                         mar.descripcion as Marca,
                                         pai.descripcion as Pais
                                FROM MARCAS as mar, paises as pai 
                                WHERE mar.idPais = pai.idPais");
        }
    }
}
