using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos
{
    public class ItemCompromisso
    {
        public class Compromisso
        {
            public string Assunto { get; set; }
            public string Local { get; set; }
            public string NomeContato { get; set; }
            public DateTime HoraInicio { get; set; }
            public DateTime HoraTermino { get; set; }
            public DateTime DataInicio { get; set; }
            public DateTime DataCompromisso { get; set; }

            public Compromisso()
            {

            }
            public Compromisso(string assunto, string local, string contato, DateTime horaInicio, DateTime horaTermino, DateTime dataInicio)
            {
                Assunto = assunto;
                Local = local;
                NomeContato = contato;
                HoraInicio = horaInicio;
                HoraTermino = horaTermino;
                DataInicio = dataInicio;

            }
        }
    }
}
