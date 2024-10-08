using ClientesApp.Domain.Entities;
using ClientesApp.Domain.Interfaces.Repositories;
using ClientesApp.Infra.Data.SqlServer.Contexts;

namespace ClientesApp.Infra.Data.SqlServer.Repositories
{
    //TEntity (Representa a entidade em sí "Cliente"), TKey(Representa a chave primária da entidade "Guid")
    public class ClienteRepository : BaseRepository<Cliente, Guid>, IClienteRepository
    {
        public ClienteRepository(DataContext dataContext): base(dataContext)
        {
        }
    }
}