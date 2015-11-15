using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksProject.Data;

namespace DrinksProject.Dal
{
    public class Type
    {
        public static List<Dto.Type> SelectAllTypes()
        {
            using (var db = new DrinkDataBaseDataContext())
            {
                return db.TYPEs.Select(c => new Dto.Type {
                
                    NAME = c.NAME,
                    PK_TYPE = c.PK_TYPE
                
                }).ToList();
            }
        }

        public static Dto.Type GetTypeName(int Id)
        {
            using (var db = new DrinkDataBaseDataContext())
            {
                return db.TYPEs.Where(c => c.PK_TYPE == Id).Select(c=>new Dto.Type {

                    PK_TYPE = c.PK_TYPE,
                    NAME = c.NAME
                
                    }).FirstOrDefault();
            }
        }
    }
}
