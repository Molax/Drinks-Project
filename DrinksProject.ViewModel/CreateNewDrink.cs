using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProject.ViewModel
{
    public class CreateNewDrink
    {
        public int PK_DINK { get; set; }

        public string NAME { get; set; }

        public string PHOTO { get; set; }

        public int FK_SIZE { get; set; }

        public int FK_TYPE { get; set; }
    }
}
