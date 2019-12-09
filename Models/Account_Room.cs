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
    public class Account_Room
    {
        public Account_Room()
        {

        }
        public Account_Room( DateTime checkIn,int room_Id, int acc_ID )
        {
            account_ID = acc_ID;
            room_ID = room_Id;
            CheckIn = checkIn;
            CheckOut = null;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public float? Discount { get; set; }
        public int? TotalPrice { get; set; }
        public int account_ID { get; set; }
        public int room_ID { get; set; }

        public virtual Account account { get; set; }
        public virtual Room room { get; set; }
    }
}
