using SkillTreeHomework.Models;

namespace SkillTreeHomework.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public Model1 Context { get; set; }

        public EFUnitOfWork()
        {
            Context = new Model1();
        }

        /// <summary>
        /// Dispose Context
        /// </summary>
        public void Dispose()
        {
            Context.Dispose();
        }

        /// <summary>
        /// Save Changes
        /// </summary>
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}