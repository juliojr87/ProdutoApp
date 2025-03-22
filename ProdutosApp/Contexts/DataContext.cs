

using Microsoft.EntityFrameworkCore;
using ProdutosApp.Mappings;

namespace ProdutosApp.Contexts
{
    public class DataContext : DbContext
    {
        //Método para configurar a conexão com o banco de dados do SqlServer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1434;Initial Catalog=master;User ID=sa;Password=Coti@2025;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}
