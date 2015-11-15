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

        public static List<Dto.Drink> SelectAllDrinks()
        {
            using (var db = new DrinkDataBaseDataContext())
            {
                return db.DRINKs.Select(c => new Dto.Drink { 
                
                    FK_SIZE = c.FK_SIZE,
                    NAME = c.NAME,
                    FK_TYPE = c.FK_TYPE,
                    PHOTO = c.PHOTO.ToArray()

                }).ToList();
            }
        }
    }
}
