using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Models
{
    public class Contato
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Tel_res { get; set; }
        public string Tel_cel { get; set; }
        public string Tel_coml { get; set; }
    }
}
