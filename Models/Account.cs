using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaraokeApp.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String PassWord { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Position { get; set; }
        public Account() { }
        public Account(string userName, string passWord, string name, String address, String possition)
        {
            UserName = userName;
            PassWord = passWord;
            Name = name;
            Address = address;
            Position = possition;
        }
        [ForeignKey("account_ID")]
        public virtual ICollection<Account_Room> account_Rooms { get; set; }
    }
}
