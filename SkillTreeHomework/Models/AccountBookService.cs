using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkillTreeHomework.Models
{
    public class AccountBookService
    {
        private readonly Model1 _db;

        public AccountBookService()
        {
            _db = new Model1();
        }

        public IEnumerable<AccountBook> LookUp()
        {
            return _db.AccountBook.ToList();
        }

        public AccountBook GetSingle(Guid id)
        {
            return _db.AccountBook.Find(id);
        }

        public void Add(AccountBook data)
        {
            _db.AccountBook.Add(data);
        }

        public void Edit(AccountBook pageData, AccountBook oldData)
        {
            oldData.Categoryyy = pageData.Categoryyy;
            oldData.Dateee = pageData.Dateee;
            oldData.Amounttt = pageData.Amounttt;
            oldData.Remarkkk = pageData.Remarkkk;
        }

        public void Delete(AccountBook data)
        {
            _db.AccountBook.Remove(data);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}