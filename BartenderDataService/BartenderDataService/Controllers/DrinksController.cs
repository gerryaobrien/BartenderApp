using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderDataService.Models;

namespace BartenderDataService.Controllers
{
    [Route ("api/drinks")]
    public class DrinksController : Controller
    {
        // Get all drinks
        [HttpGet]
        public Drink[] Get()
        {
            return Repository.Drinks.ToArray();
        }

        // Get drink by ID
        [HttpGet("{id}")]
        public Drink Get(int id)
        {
            return Repository.GetDrinkById(id);
        }

        // Get drink by category
        [HttpGet("{category}")]
        public Drink[] Get(string category)
        {
            return Repository.GetDrinkByCategory(category);
        }
        
        // Create a new Drink
        [HttpPost]
        public void Post([FromBody]Drink drink)
        {
            Repository.AddDrink(drink);
        }

        // Update an existing drink
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Drink drink)
        {
            Repository.UpdateDrink(id, drink);
        }

        // Remove a drink by name
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            Repository.DeleteDrink(name);
        }
    }
}
