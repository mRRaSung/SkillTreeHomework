using SkillTreeHomework.Repositories;
using System;
using System.Collections.Generic;

namespace SkillTreeHomework.Models
{
    public class AccountBookService
    {
        private readonly IRepository<AccountBook> _repAccountBook;
        private readonly IUnitOfWork _uniOfWork;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _uniOfWork = unitOfWork;
            _repAccountBook = new Repository<AccountBook>(_uniOfWork);
        }

        public IEnumerable<AccountBook> LookUp()
        {
            return _repAccountBook.LookupAll();
        }

        public AccountBook GetSingle(Guid id)
        {
            return _repAccountBook.GetSingle(x => x.Id.Equals(id));
        }

        public void Add(AccountBook data)
        {
            _repAccountBook.Create(data);
        }

        public void Edit(AccountBook data)
        {
            _repAccountBook.Update(data);
        }

        public void Delete(AccountBook data)
        {
            _repAccountBook.Remove(data);
        }

        public void Save()
        {
            _repAccountBook.Commit();
        }
    }
}