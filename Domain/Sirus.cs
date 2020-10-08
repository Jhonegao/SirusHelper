using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sirus
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public byte Awakener { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Completado { get; set; }
        public bool Ativo { get; set; }
    }
}
