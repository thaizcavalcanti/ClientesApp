using System.Linq.Expressions;

namespace ClientesApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface genérica para operações do repositório
    /// </summary>
    /// <TEntity (Representa a entidade em sí), TKey(Representa a chave primária da entidade) > Nomes aleatórios.
    public interface IBaseRepository<TEntity, TKey> : IDisposable //IDisposable, liberar recursos, melhorar a performance
        where TEntity : class //tipo genérico, mas quer que ele seja uma classe
    {
        //Por padrão, quando o método for assincrono(Task), colocar o nome dele terminando como Async ex.: AddAsync
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity?> GetOneAsync(Expression<Func<TEntity, bool>> where);
        Task<TEntity?> GetByIdAsync(TKey id);
    }
}