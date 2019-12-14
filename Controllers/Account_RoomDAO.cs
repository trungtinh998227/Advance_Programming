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
        public Account_Room GetAccount_Room(int roomID)
        {
            Console.WriteLine(db.Account_Rooms.FirstOrDefault(ac => ac.room.ID == roomID).ToString());
            return db.Account_Rooms.FirstOrDefault(ac => ac.room.ID == roomID);
        }
        public void updateAccR(int roomID, int newRoomID)
        {
            Account_Room arc = GetAccount_Room(roomID);
            arc.room_ID = newRoomID;
            db.SaveChanges();
        }
    }
}
