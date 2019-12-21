using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KaraokeApp.Models
{
    public class BillInfor
    {
        public BillInfor() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        public DateTime? checkIn { get; set; }
        public DateTime? checkOut { get; set; }
        public String RoomName { get; set; }
        public String AccountName { get; set; }
        public int? DisCount { get; set; }
        public int Payment { get; set; }
        public int GuessPay { get; set; }
        public int ExcessCash { get; set; }
        public string PayType { get; set; }
        [ForeignKey("BillInfor_ID")]
        public virtual List<Food_Room> food_Rooms { get; set; }
    }
}
