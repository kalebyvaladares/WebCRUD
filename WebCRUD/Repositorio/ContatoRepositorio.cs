using WebCRUD.Data;
using WebCRUD.Models;

namespace WebCRUD.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Alterar(ContatoModel contato)
        {
            ContatoModel ContatoDB = ListarPorId(contato.Id);
            if (ContatoDB == null) throw new System.Exception("Erro na alteração do contato.");

            ContatoDB.Nome = contato.Nome;
            ContatoDB.Email = contato.Email;
            ContatoDB.Celular = contato.Celular;

            _bancoContext.Contatos.Update(ContatoDB);
            _bancoContext.SaveChanges();
            return ContatoDB;
        }
        public bool Apagar(int id)
        {
            ContatoModel ContatoDB = ListarPorId(id);
            if (ContatoDB == null) throw new System.Exception("Erro na deleção do contato.");
            _bancoContext.Contatos.Remove(ContatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
