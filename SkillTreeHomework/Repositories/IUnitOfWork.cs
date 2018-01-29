using SkillTreeHomework.Models;
using System;

namespace SkillTreeHomework.Repositories
{
    /// <summary>
    /// 用於交易連線的抽離與共用 (在多資料表操作時，避免dirty data)
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Context
        /// </summary>
        Model1 Context { get; set; }
        /// <summary>
        /// Save Change
        /// </summary>
        void Save();
    }
}