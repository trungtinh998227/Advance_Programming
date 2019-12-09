using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Controllers
{
    class AccountDAO
    {
        private static AccountDAO instance;
        KaraokeContext db = KaraokeContext.Instance;
        private AccountDAO() { }

        internal static AccountDAO Instance {
            get {if(instance==null) instance = new AccountDAO(); return AccountDAO.instance; }
            set => instance = value; 
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
        public int ValidateAccount(String userName, String passWord)
        {
            return (db.Accounts.FirstOrDefault(a => a.PassWord == passWord && a.UserName == userName).ID);     
        }
    }
}
