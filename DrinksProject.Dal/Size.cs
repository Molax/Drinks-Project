using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DrinksProject.Data;

namespace DrinksProject.Dal
{
    public class Size
    {
        public static List<Dto.Size> SelectAllSizes()
        {
            using (var db = new DrinkDataBaseDataContext())
            {
                return db.SIZEs.Select(c => new Dto.Size {
                
                    SIZETYPE = c.SIZETYPE,
                    PK_SIZE  = c.PK_SIZE
                
                }).ToList();
            }
        }
    }
}
