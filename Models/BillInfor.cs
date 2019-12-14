using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KaraokeApp.Models
{
    class BillInfor
    {
        public BillInfor() { }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public String FoodName { get; set; }
        public String RoomName { get; set; }
        public String AccountName { get; set; }
        public String Amount { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
    }
}
