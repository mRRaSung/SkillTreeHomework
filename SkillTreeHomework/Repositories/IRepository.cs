using System;
using System.Linq;
using System.Linq.Expressions;

namespace SkillTreeHomework.Repositories
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Unit of work
        /// </summary>
        IUnitOfWork UnitOfWork { get; set; }
        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns>IQueryable<T>.</returns>
        IQueryable<T> LookupAll();
        /// <summary>
        /// 條件搜尋
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Query(Expression<Func<T, bool>> filter);
        /// <summary>
        /// 取得單一 entity
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> filter);
        /// <summary>
        /// 新增一個entity
        /// </summary>
        /// <param name="entity"></param>
        void Create(T entity);
        /// <summary>
        /// 更新一個entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);
        /// <summary>
        /// 刪除單一entity
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);
        /// <summary>
        /// Save change
        /// </summary>
        void Commit();
    }
}