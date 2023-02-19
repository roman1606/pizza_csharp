using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Pineapple=true,
                FinalPrice=6
            },
            new PizzasModel()
            {
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Mushroom=true,
                FinalPrice=6
            },
            new PizzasModel()
            {
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                Peperoni=true,
                FinalPrice=7
            },
            new PizzasModel()
            {
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Peperoni=true,
                FinalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="SeaFood",
                PizzaName="SeaFood",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                Pineapple=true,
                FinalPrice=6
            }
        };

        public void OnGet()
        {
        }
    }
}
