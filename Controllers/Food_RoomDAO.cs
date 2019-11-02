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
        private KaraokeContext db;
        public Food_RoomDAO(KaraokeContext context)
        {
            this.db = context;
        }
        public void AddFood_Room(Food_Room food_Room)
        {
            try
            {
                db.Food_Rooms.Add(food_Room);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
    }
}
