using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DrinksProject.Data;

namespace DrinksProject.Dal
{
    public class Drink
    {
        public static void CreateNewDrink(Dto.Drink drink)
        {
            using (var db = new DrinkDataBaseDataContext())
            {
                var dbDrink = new Data.DRINK()
                {
                    FK_SIZE = drink.FK_SIZE,
                    NAME = drink.NAME,
                    FK_TYPE = drink.FK_TYPE,
                    PHOTO = drink.PHOTO
                };

                db.DRINKs.InsertOnSubmit(dbDrink);

                db.SubmitChanges();
            }
        }
    }
}
