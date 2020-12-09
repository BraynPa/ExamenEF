using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793EF.Models
{
    public class Note
    {
        public int Id { set; get; }
        public string Titulo { set; get; }
        public DateTime Fecha { set; get; }
        public string Contenido { set; get; }
    }
}
