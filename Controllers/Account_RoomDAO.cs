using KaraokeApp.Models;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace KaraokeApp.Controllers
{
    class Account_RoomDAO
    {
        private static Account_RoomDAO Instance;
        private KaraokeContext db = KaraokeContext.Instance;

        internal static Account_RoomDAO instance {
            get {if (Instance==null) Instance = new Account_RoomDAO(); return Account_RoomDAO.Instance; } 
            set => Instance = value; }
        private Account_RoomDAO() { }
        public void AddAccount_Room(Account_Room account_room)
        {
            try
            {
                if (db.Account_Rooms.FirstOrDefault(ac => ac.CheckIn == account_room.CheckIn && ac.room_ID == account_room.room_ID) == null)
                {
                    db.Account_Rooms.Add(account_room);
                    db.SaveChanges();
                }
            }
            catch(Exception e)
            {
                e.ToString();
            }
                
        }
        public void RemoveLastValue()
        {
            try
            {
                Console.WriteLine(db.Account_Rooms.Max(s=>s.ID));
                db.SaveChanges();
            }
            catch(Exception e)
            {
                e.ToString();
            }
            
        }
    }
}
