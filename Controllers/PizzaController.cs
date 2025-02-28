using Microsoft.AspNetCore.Mvc;
using ContossoPizza.Models;
using ContossoPizza.Services;
using System.Collections.Generic;

namespace ContossoPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService;

        public PizzaController()
        {
            _pizzaService = new PizzaService(); // Initialize the service
        }

        // GET: api/pizza
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> GetPizzas()
        {
            var pizzas = _pizzaService.GetAllPizzas();
            return Ok(pizzas);
        }

        // GET: api/pizza/{id}
        [HttpGet("{id}")]
        public ActionResult<Pizza> GetPizzaById(int id)
        {
            var pizza = _pizzaService.GetAllPizzas().FirstOrDefault(p => p.Id == id);
            if (pizza == null)
            {
                return NotFound(); // 404 if pizza not found
            }
            return Ok(pizza); // Return the found pizza
        }

        // POST: api/pizza
        [HttpPost]
        public ActionResult<Pizza> AddPizza(Pizza pizza)
        {
            var addedPizza = _pizzaService.AddPizza(pizza);
            return CreatedAtAction(nameof(GetPizzaById), new { id = addedPizza.Id }, addedPizza);
        }

        // PUT: api/pizza/{id}
        [HttpPut("{id}")]
        public ActionResult<Pizza> UpdatePizza(int id, Pizza pizza)
        {
            var existingPizza = _pizzaService.GetAllPizzas().FirstOrDefault(p => p.Id == id);
            if (existingPizza == null)
            {
                return NotFound(); // 404 if pizza to update not found
            }

            // Update the existing pizza
            existingPizza.Name = pizza.Name;
            existingPizza.Description = pizza.Description;
            existingPizza.Price = pizza.Price;

            return Ok(existingPizza); // Return the updated pizza
        }

        // DELETE: api/pizza/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePizza(int id)
        {
            var pizza = _pizzaService.GetAllPizzas().FirstOrDefault(p => p.Id == id);
            if (pizza == null)
            {
                return NotFound(); // 404 if pizza not found
            }

            // Remove the pizza from the list
            var pizzaList = _pizzaService.GetAllPizzas().ToList();
            pizzaList.Remove(pizza);

            return NoContent(); // Return 204 No Content (successful deletion)
        }
    }
}
