using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Models
{
    class RoomDAO
    {
        private KaraokeContext db = KaraokeContext.Instance;
        private static RoomDAO instance;

        internal static RoomDAO Instance {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; } 
            set => instance = value; 
        }

        public RoomDAO(){ }


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

        public void UpdateRoom(Room room)
        {
            try
            {
                //Get this room and update value
                Room r = GetRoom(room.ID);
                r.RoomStatus = room.RoomStatus;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public void UpdateRoom(int roomID, String status)
        {
            try
            {
                //Get this room and update value
                Room r = GetRoom(roomID);
                r.RoomStatus = status;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public Room GetRoom(int ID)
        {
            return db.Rooms.FirstOrDefault<Room>(r => r.ID == ID);
        }
        public Room GetRoom(String Name)
        {
            return db.Rooms.FirstOrDefault<Room>(r => r.Name == Name);
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
        public List<Room> GetEmptyRoom(String roomTyle)
        {
            return db.Rooms.Where(r => r.RoomStatus == Constants.ROOM_STATUS.EMPTY && r.RoomType == roomTyle).ToList();
        }
    }
}
