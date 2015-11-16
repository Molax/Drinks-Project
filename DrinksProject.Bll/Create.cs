using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProject.Bll
{
    public class Create
    {

        public static void CreateNewDrink(ViewModel.CreateNewDrink Drink)
        {
            Dal.Drink.CreateNewDrink(new Dto.Drink { 
            
                FK_SIZE = Drink.FK_SIZE,
                FK_TYPE = Drink.FK_TYPE,
                NAME = Drink.NAME,
                PHOTO = Drink.PHOTO,
                PRICE = Drink.PRICE

            });
        }
    }
}
