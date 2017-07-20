using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderDataService.Models
{
    public class Repository
    {
        private static int counter;

        public static List<Drink> Drinks { get; } = new List<Drink>();

        public static Drink GetDrinkById(int id)
        {
            var target = Drinks.SingleOrDefault(d => d.ID == id);
            return target;
        }

        public static Drink[] GetDrinkByCategory(string category)
        {
            var target = Drinks.FindAll(d => d.category == category).ToArray() ;
            return target;
        }

        public static void UpdateDrink(int id, Drink drink)
        {
            var target = Drinks.SingleOrDefault(d => d.ID == id);

            if(target != null)
            {
                Drinks.Remove(target);
                Drinks.Add(drink);
            }
        }

        public static void AddDrink(Drink d)
        {
            d.ID = counter++;
            Drinks.Add(d);
        }

        public static void DeleteDrink(string name)
        {
            bool result = true;
            var target = Drinks.SingleOrDefault(d => d.name == name);

            if (target != null)
            {
                try
                {
                    Drinks.Remove(target);
                }
                catch (Exception ex)
                {
                    result = false;
                }
                result = true;
            }

            //return result;
        }
    }
}
