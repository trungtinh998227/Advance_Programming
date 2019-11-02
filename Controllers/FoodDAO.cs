using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Controllers
{
    class FoodDAO
    {
        private KaraokeContext db;
        public FoodDAO(KaraokeContext context)
        {
            this.db = context;
        }

        public void AddFood(Food food)
        {
            try
            {
                db.Foods.Add(food);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
        public List<Food> GetFoods()
        {
            return db.Foods.Where(f => f.FoodType == Constants.FOOD_TYPE.FOOD).ToList();
        }
        public List<Food> GetDrinks()
        {
            return db.Foods.Where(d => d.FoodType == Constants.FOOD_TYPE.DRINK).ToList();
        }
        public Food GetFoodByName(string name)
        {
            return db.Foods.FirstOrDefault(f => f.Name == name);
        }
    }
}
