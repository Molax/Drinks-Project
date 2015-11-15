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

            return Drinks;
        }
    }
}
