using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Lab01
{
    [Table]
    public class Usuarios
    {
        [Column(IsPrimaryKey=true)]
        public string usuario { get; set; }

        [Column]
        public string clave { get; set; }
    }
}
