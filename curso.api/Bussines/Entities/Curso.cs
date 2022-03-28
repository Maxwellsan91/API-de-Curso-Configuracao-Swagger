using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Bussines.Entities
{
    public class Curso
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int CodUsuario { get; set; }

        public virtual Usuario Usuario{ get; set; }
    }
}
