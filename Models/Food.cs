using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeApp.Models
{
    public class Food
    {
        public Food() { }

        public Food(string name, int inventory, string unit, int price, string foodType)
        {
            Name = name;
            Inventory = inventory;
            Unit = unit;
            Price = price;
            FoodType = foodType;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required] 
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public int Inventory { get; set; }
        [Required]
        public String Unit { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public String FoodType { get; set; }

        public virtual ICollection<Food_Room> food_Room { get; set; }
        public virtual Producer producers { get; set; }
    }
}
