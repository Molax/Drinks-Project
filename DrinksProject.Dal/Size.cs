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


        public static Dto.Size GetSizeName(int Id)
        {
            using (var db = new DrinkDataBaseDataContext())
            {
                return db.SIZEs.Where(c => c.PK_SIZE == Id).Select(c => new Dto.Size {
                
                    PK_SIZE = c.PK_SIZE,
                    SIZETYPE = c.SIZETYPE
                
                }).FirstOrDefault();
            }
        }
    }
}
