using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContatos.Dominio
{
    [Serializable]
    public class ItemContato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override string ToString()
        {
            return Nome + " | " + Email + " | " + Telefone + " | " + Empresa + " | " + Cargo;
        }
    }
}
