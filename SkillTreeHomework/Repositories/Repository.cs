using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SkillTreeHomework.Repositories
{
    /// <summary>
    /// 於建構時，指定共用的交易連線 (多資料表操作時，避免dirty data)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; set; }

        private DbSet<T> _Objectset;
        private DbSet<T> ObjectSet
        {
            get
            {
                if (_Objectset == null)
                {
                    _Objectset = UnitOfWork.Context.Set<T>();
                }
                return _Objectset;
            }
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="unitOfWork"></param>
        public Repository(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="entity"></param>
        public void Create(T entity)
        {
            ObjectSet.Add(entity);
        }

        /// <summary>
        /// 更新一筆資料
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            ObjectSet.Attach(entity);
        }

        /// <summary>
        /// 取得一筆資料
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public T GetSingle(Expression<Func<T, bool>> filter)
        {
            return ObjectSet.SingleOrDefault(filter);
        }

        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> LookupAll()
        {
            return ObjectSet;
        }

        /// <summary>
        /// 條件查詢
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public IQueryable<T> Query(Expression<Func<T, bool>> filter)
        {
            return ObjectSet.Where(filter);
        }

        /// <summary>
        /// 移除一筆資料
        /// </summary>
        /// <param name="entity"></param>
        public void Remove(T entity)
        {
            ObjectSet.Remove(entity);
        }

        /// <summary>
        /// 儲存全部交易
        /// </summary>
        public void Commit()
        {
            UnitOfWork.Save();
        }
    }
}