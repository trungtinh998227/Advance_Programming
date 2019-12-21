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
                if (db.Account_Rooms.FirstOrDefault(ac => ac.CheckIn == account_room.CheckIn && ac.room_ID == account_room.room_ID && ac.PayStatus == Constants.BILL_TYPE.UNPAY) == null)
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
            return db.Account_Rooms.FirstOrDefault(ac => ac.room.ID == roomID && ac.PayStatus != Constants.BILL_TYPE.PAY);
        }
        public void updateAccR(int roomID, int newRoomID)
        {
            try
            {
                Account_Room arc = GetAccount_Room(roomID);
                arc.room_ID = newRoomID;
                db.SaveChanges();
            }catch(Exception e)
            {
                e.ToString();
            }
        }
        public void UpdateAccountRoom(Account_Room account_Room)
        {
            var ac_r = db.Account_Rooms.FirstOrDefault(ac => ac.ID == account_Room.ID);
            ac_r.CheckOut = account_Room.CheckOut;
            ac_r.Discount = account_Room.Discount;
            ac_r.TotalPrice = account_Room.TotalPrice;
            ac_r.PayStatus = account_Room.PayStatus;
            db.SaveChanges();
        }
    }
}
