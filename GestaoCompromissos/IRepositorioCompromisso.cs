using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCompromissos
{
    internal interface IRepositorioCompromisso
    {
        void AdicionarItens(Compromisso CompromissoSelecionado, List<ItemCompromisso> itens);
        void AtualizarItens(Compromisso CompromissoSelecionado, List<ItemCompromisso> itensConcluidos, List<ItemCompromisso> itensPendentes);
        void Editar(Compromisso Compromisso);
        void Excluir(Compromisso Compromisso);
        void Inserir(Compromisso novoCompromisso);
        List<Compromisso> SelecionarTodos();

        List<Compromisso> SelecionarCompromissosConcluidos();

        List<Compromisso> SelecionarCompromissosPendentes();
    }
}
