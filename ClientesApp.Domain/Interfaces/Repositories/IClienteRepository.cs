using ClientesApp.Domain.Entities;

namespace ClientesApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface para especialização do repositório de clientes
    /// </summary>
    public interface IClienteRepository : IBaseRepository<Cliente, Guid>
    {
    }
}
