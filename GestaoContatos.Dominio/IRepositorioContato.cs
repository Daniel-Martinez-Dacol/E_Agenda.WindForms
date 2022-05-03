using System.Collections.Generic;

namespace GestaoContatos.Dominio
{
    public interface IRepositorioContato
    {
        void AdicionarItens(Contato ContatoSelecionada, List<ItemContato> itens);
        void AtualizarItens(Contato ContatoSelecionada, List<ItemContato> itensConcluidos, List<ItemContato> itensPendentes);
        void Editar(Contato Contato);
        void Excluir(Contato Contato);
        void Inserir(Contato novaContato);
        List<Contato> SelecionarTodos();

        List<Contato> SelecionarContatosConcluidos();

        List<Contato> SelecionarContatosPendentes();

    }
}
