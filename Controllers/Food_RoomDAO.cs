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
