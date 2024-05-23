using WebCRUD.Models;

namespace WebCRUD.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Alterar(ContatoModel contato);
        bool Apagar(int id);
    }
}
