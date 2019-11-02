using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Models
{
    class RoomDAO
    {
        private KaraokeContext db;

        public RoomDAO(){ }

        public RoomDAO(KaraokeContext context)
        {
            this.db = context;
        }

        public void AddRoom(Room room)
        {
            try
            {
                db.Rooms.Add(room);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public IEnumerable<Room> GetRooms()
        {
            return db.Rooms;
        }
        public List<Room> GetRoomNormal()
        {
            return db.Rooms.Where(r => r.RoomType == Constants.RoomType.NORMAL).ToList();
        }
        public List<Room> GetRoomVIP()
        {
            return db.Rooms.Where(r => r.RoomType == Constants.RoomType.VIP).ToList();
        }
        public List<Room> GetEmptyRoom()
        {
            return db.Rooms.Where(r => r.RoomStatus == Constants.ROOM_STATUS.EMPTY).ToList();
        }
    }
}
