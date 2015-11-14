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
            byte[] bytes = Convert.FromBase64String(Drink.PHOTO);
        }
    }
}
