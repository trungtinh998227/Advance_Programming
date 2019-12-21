using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaraokeApp.Models
{
    [Table("Room")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]  
        public String Name { get; set; }
        public String RoomStatus { get; set; }
        public String RoomType { get; set; }
        public int Price { get; set; }
        public Room() { }

        public Room(string name, string roomStatus, string roomType, int price)
        {
            Name = name;
            RoomStatus = roomStatus;
            RoomType = roomType;
            Price = price;
        }
        [ForeignKey("room_ID")]
        public virtual ICollection<Account_Room> account_Rooms { get; set; }
        public virtual ICollection<Food_Room> food_Rooms { get; set; }
    }
}
