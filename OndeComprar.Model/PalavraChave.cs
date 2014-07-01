using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndeComprar.Model
{
    public class PalavraChave
    {
        public Int64 PalavraChaveId { get; set; }
        public string Termo { get; set; }
        public Categoria Categoria { get; set; }
    }
}
