using ClientesApp.Infra.Data.SqlServer.Mappings;
using Microsoft.EntityFrameworkCore;
namespace ClientesApp.Infra.Data.SqlServer.Contexts
{
    /// <summary>
    /// Classe de contexto para configuração do acesso ao banco de dados feito pelo EntityFramework
    /// </summary>
    public class DataContext : DbContext
    {
        //método construtor [ctor] + [tab]
        //construtor para receber as preferencias / configurações para acesso ao banco de dados pelo EntityFramework
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
        }
    }
}