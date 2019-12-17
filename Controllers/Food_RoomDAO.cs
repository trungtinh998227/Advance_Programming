using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Controllers
{
    class Food_RoomDAO
    {
        private static Food_RoomDAO instance;
        private KaraokeContext db = KaraokeContext.Instance;
        private Food_RoomDAO() { }

        internal static Food_RoomDAO Instance
        {
            get { if (instance == null) instance = new Food_RoomDAO(); return Food_RoomDAO.instance; }
            set => instance = value;
        }

        public void AddFood_Room(Food_Room food_Room)
        {
            try
            {
                if (db.Food_Rooms.FirstOrDefault(fr => fr.room.ID == food_Room.room.ID && fr.Food.ID == food_Room.Food.ID && fr.PayStatus == Constants.BILL_TYPE.UNPAY) == null)
                {
                    db.Food_Rooms.Add(food_Room);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public void DeleteFoodRoom(Food_Room food_Room)
        {
            db.Food_Rooms.Remove(food_Room);
            db.SaveChanges();
        }

        public void UpdateFoodRoom(int frID, int value, int totalPrice)
        {
            Food_Room fr = GetFood_RoomByID(frID);
            fr.Amount = value;
            fr.TotalPrice = totalPrice;
            db.SaveChanges();
        }
        public void UpdateFoodRoom(Food_Room fr, Room newRoom)
        {
            fr.room = newRoom;
            db.SaveChanges();
        }
        public List<Food_Room> GetFood_RoomByRoomID(int roomID)
        {
            return (from c in db.Food_Rooms
                    where c.room.ID == roomID &&
                    c.BillInfor_ID == null &&
                    c.PayStatus == "UNPAY"
                    select c).ToList();
        }
        public Food_Room GetFood_RoomByID(int roomID, int FoodID)
        {
            return db.Food_Rooms.FirstOrDefault(fr=>fr.room.ID == roomID && fr.Food.ID == FoodID && fr.BillInfor_ID == null);
        }
        public Food_Room GetFood_RoomByID(int frID)
        {
            return db.Food_Rooms.FirstOrDefault(fr => fr.ID == frID);
        }
    }
}
