using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppOnTime.Web.Controllers
{
    public class DrinkController : ApiController
    {
        [HttpPost]
        public void CreateNewDrink(DrinksProject.ViewModel.CreateNewDrink Drink)
        {
            Drink.PHOTO = System.Text.Encoding.UTF8.GetBytes(Drink.PHOTOCODED);

            DrinksProject.Bll.Create.CreateNewDrink(Drink);
        }

        [HttpPost]
        public List<DrinksProject.ViewModel.SelectAllDrinks> SelectAllDrinks()
        {
            List<DrinksProject.ViewModel.SelectAllDrinks> Drinks =  DrinksProject.Bll.Select.SelectAllDrinks();

            foreach (var item in Drinks)
            {
                item.PHOTO = String.Format("<div align=center><img src='{0}' width='50' vspace='5'></div>", item.PHOTO);
            }

            return Drinks;
        }

        [HttpPost]
        public DrinksProject.ViewModel.GetNumberOfDrinksByType GetNumberOfDrinksByType()
        {
            return DrinksProject.Bll.Select.GetNumberOfDrinksByType(1);
        }
    }
}
