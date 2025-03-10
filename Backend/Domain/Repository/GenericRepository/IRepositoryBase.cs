﻿
namespace Task_Management_System.Domain.Repository.GenericRepository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        bool Add(TEntity entity);
        Task<bool> AddAsync(TEntity entity);
        bool AddRange(IEnumerable<TEntity> entities);
        Task<bool> AddRangeAsync(IEnumerable<TEntity> entities);
        void AddRangeTrans(IEnumerable<TEntity> entities);   
        IQueryable<TEntity> All<TProperty>(params Expression<Func<TEntity, TProperty>>[] path);
        IQueryable<TEntity> All(params string[] path);
        long CountAll();
        Task<long> CountAllAsync();
        bool Exist(long id);
        Task<bool> ExistAsync(long id);
        bool ExistWhere(Expression<Func<TEntity, bool>> predicate);
        Task<bool> ExistWhereAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(long id);
        Task<TEntity> FindAsync(long id);
        TEntity First<TProperty>(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, TProperty>>[] path);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate, params string[] path);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params string[] path);
        bool RemoveList(IEnumerable<TEntity> entities);
        bool Remove(TEntity entity);
        void RemoveTrans(TEntity entity);
        bool Update(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);
        Task<bool> UpdateRangeAsync(IEnumerable<TEntity> entities);
        IQueryable<TEntity> Where<TProperty>(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, TProperty>>[] path);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate, params string[] includes);
        List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        IQueryable<TEntity> Query();
        Task<IReadOnlyList<TEntity>> GetPagedResponseAsync(int pageNumber, int pageSize ,Expression<Func<TEntity, bool>> predicate, params string[] includes);
    }
}
