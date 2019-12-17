using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    public class Food_Room
    {
        public Food_Room() { }
        public Food_Room(int amount, int totalPrice)
        {
            Amount = amount;
            TotalPrice = totalPrice;
            PayStatus = Constants.BILL_TYPE.UNPAY;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
        public int? BillInfor_ID { get; set; }

        public string PayStatus { get; set; }

        public virtual Room room { get; set; }
        public virtual Food Food { get; set; }
        public virtual BillInfor BillInfor { get; set; }
    }
}
