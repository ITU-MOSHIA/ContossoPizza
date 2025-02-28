using ContossoPizza.Models;
using System.Collections.Generic;

namespace ContossoPizza.Services
{
    public class PizzaService
    {
        private static List<Pizza> pizzas = new List<Pizza>
        {
           new Pizza { Id = 1, Name = "Margherita", Description = "Classic pizza with tomato, mozzarella, and basil", Price = 79.99m },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Spicy pepperoni with mozzarella", Price = 89.99m },
            new Pizza { Id = 3, Name = "BBQ Chicken", Description = "Smoked chicken with BBQ sauce, red onions, and mozzarella", Price = 99.99m },
            new Pizza { Id = 4, Name = "Hawaiian", Description = "Sweet pineapple with ham and mozzarella on a tomato base", Price = 84.99m },
            new Pizza { Id = 5, Name = "Veggie Supreme", Description = "A mix of fresh vegetables including bell peppers, mushrooms, olives, and spinach", Price = 87.99m },
            new Pizza { Id = 6, Name = "Meat Feast", Description = "Loaded with pepperoni, sausage, bacon, and ground beef", Price = 104.99m },
            new Pizza { Id = 7, Name = "Seafood Delight", Description = "Shrimp, scallops, and calamari with a light garlic sauce", Price = 119.99m },
            new Pizza { Id = 8, Name = "Buffalo Chicken", Description = "Grilled chicken with spicy buffalo sauce, blue cheese, and celery", Price = 94.99m },
            new Pizza { Id = 9, Name = "Pesto Veggie", Description = "Pesto sauce with artichokes, spinach, sun-dried tomatoes, and mozzarella", Price = 82.99m },
            new Pizza { Id = 10, Name = "Truffle Mushroom", Description = "A rich mix of wild mushrooms with truffle oil and mozzarella", Price = 124.99m }
        };

        public IEnumerable<Pizza> GetAllPizzas()
        {
            return pizzas;
        }

        public Pizza AddPizza(Pizza pizza)
        {
            pizza.Id = pizzas.Count + 1;
            pizzas.Add(pizza);
            return pizza;
        }
    }
}
