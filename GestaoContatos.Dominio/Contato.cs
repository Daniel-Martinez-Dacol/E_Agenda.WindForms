using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoContatos.Dominio
{
    public class Contato
    {
        private List<ItemContato> itens = new List<ItemContato>();

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }       
        public List<ItemContato> Itens { get { return itens; } }
        
        public Contato()
        {

        }

        public Contato(string n, string e, string t, string m, string c) : this()
        {
            Nome = n;
            Email = e;
            Telefone = t;
            Empresa = m;
            Cargo = c;
        }
        public void AdicionarItem(ItemContato item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, Empresa:{Empresa}, Cargo: {Cargo} ";
        }
    }
}
