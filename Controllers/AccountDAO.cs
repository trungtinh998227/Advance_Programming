using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Controllers
{
    class AccountDAO
    {
        private KaraokeContext db;
        public AccountDAO(KaraokeContext context)
        {
            this.db = context;
        }
        public void AddAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public Account GetAccountByID(int Id)
        {
            return db.Accounts.FirstOrDefault(a => a.ID == Id);
        }
        public string ValidateAccount(String userName, String passWord)
        {
            return (db.Accounts.FirstOrDefault(a => a.PassWord == passWord && a.UserName == userName).Position);     
        }
    }
}
