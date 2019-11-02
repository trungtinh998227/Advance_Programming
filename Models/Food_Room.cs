using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    class Food_Room
    {
        public Food_Room() { }
        public Food_Room(int iD, int amount, int totalPrice)
        {
            ID = iD;
            Amount = amount;
            TotalPrice = totalPrice;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Amount { get; set; }
        public int TotalPrice { get; set; }
        
        public Room room { get; set; }
        public Food Food { get; set; }
    }
}
