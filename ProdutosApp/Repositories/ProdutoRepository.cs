using ProdutosApp.Contexts;
using ProdutosApp.Entities;

namespace ProdutosApp.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para produto
    /// </summary>
    public class ProdutoRepository
    {
        //Método para inserir um produto no banco de dados
        public void Inserir(Produto produto)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Add(produto);
                dataContext.SaveChanges();
            }
        }

        //Método para atualizar um produto no banco de dados
        public void Atualizar(Produto produto)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Update(produto);
                dataContext.SaveChanges();
            }
        }

        //Método para excluir um produto do banco de dados
        public void Excluir(Produto produto)
        {
            //abrindo conexão com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(produto);
                dataContext.SaveChanges();
            }
        }
        //Método para consultar 1 produto através do ID
        public Produto? ObterPorId(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext
                    .Set<Produto>()
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

    }
}