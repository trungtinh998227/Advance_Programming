using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    public class Producer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String Country { get; set; }
        public Producer() { }
        public Producer(string name, string address, string country)
        {
            Name = name;
            Address = address;
            Country = country;
        }
        public virtual ICollection<Food> Food { get; set; }
    }
}
