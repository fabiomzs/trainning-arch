using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainning.Arch.Domain.Entities
{
    public class Pessoa : Entity
    {
        public string Nome { get; private set; }
        public DateTime Birth { get; private set; }
        public bool Active { get; set; }
        
        //Endereço

        //Documento (CPF)
    }
}
