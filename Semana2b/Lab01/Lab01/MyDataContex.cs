using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Lab01
{
    public class MyDataContex:DataContext
    {
        public static string cadena="Data Source=isostore:/Eventos.sdf";
        public Table<Usuarios> listaUsuarios;
        public Table<Participantes> listaParticipantes;

        public MyDataContex(string cadenaConexion):
        base(cadenaConexion){ 
        }

    }
}
