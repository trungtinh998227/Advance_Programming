using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    [Table("Account_Room")]
    class Account_Room
    {
        public Account_Room()
        {

        }

        public Account_Room(DateTime checkIn, DateTime checkOut, string guestPhone, string dayType, float discount, int totalPrice)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
            GuestPhone = guestPhone;
            DayType = dayType;
            Discount = discount;
            TotalPrice = totalPrice;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public String GuestPhone { get; set; }
        public String DayType { get; set; }
        public float Discount { get; set; }
        public int TotalPrice { get; set; }

        public Account account { get; set; }
        public Room room { get; set; }
    }
}
