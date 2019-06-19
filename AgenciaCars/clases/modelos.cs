using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaCars.clases;
using System.Data;

namespace AgenciaCars.clases
{
    class modelos
    {
        acceso_BD _BD = new acceso_BD();

        public DataTable buscarModelos(){
            return _BD.consulta(@"SELECT mod.idModelo as Id,
                                         mod.descripcion as Modelo,
                                         mar.descripcion as Marca 
                                 FROM MODELOS as mod, MARCAS as mar
                                 WHERE mod.idMarca = mar.idMarca");
        }

        public DataTable ConsultarModelosMarca(String idMarca)
        {
            return _BD.consulta("SELECT * FROM MODELOS WHERE idMarca=" + idMarca);
        }
    }
}
