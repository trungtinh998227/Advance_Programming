using KaraokeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KaraokeApp.Controllers
{
    class FoodDAO
    {
        private static FoodDAO instance;
        private KaraokeContext db = KaraokeContext.Instance;

        internal static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            set => instance = value;
        }

        private FoodDAO() { }

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
        public Food GetFoodByID(int id)
        {
            return db.Foods.FirstOrDefault(f => f.ID == id);
        }
        public String GetFoodNameByID(int id)
        {
            return db.Foods.FirstOrDefault(f => f.ID == id).Name;
        }
        public String getStyleOfFoodByName(String name)
        {
            return db.Foods.FirstOrDefault(fn => fn.Name == name).FoodType;
        }
    }
}
