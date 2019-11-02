using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Controllers
{
    class Account_RoomDAO
    {
        private KaraokeContext db;
        public Account_RoomDAO(KaraokeContext context)
        {
            this.db = context;
        }
        public void AddAccount_Room(Account_Room account_room)
        {
            try
            {
                db.Account_Rooms.Add(account_room);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
    }
}
