
namespace RentCar.Data.Common.Repositories
{
    public interface IDeletableEntityRepository<TEntity> : IRepository<TEntity> 
        where TEntity : class
    {
        IQueryable<TEntity> GetAllWithDeleted();

        IQueryable<TEntity> GetAllAsNoTrackingWithDeleted();

        Task<TEntity> GetByIdWithDeletedAsync(params object[] id);

        Task HardDelete(TEntity entity);

        Task Undelete(TEntity entity);
    }
}
