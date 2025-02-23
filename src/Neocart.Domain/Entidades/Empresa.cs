using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neocart.Domain.Entities
{
    class Empresa
    {
        public Guid Id { get; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
    }
}
