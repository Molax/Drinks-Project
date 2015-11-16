using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProject.ViewModel
{
    public class CreateNewDrink
    {
        public string NAME { get; set; }

        public string PHOTOCODED { get; set; }

        public int FK_SIZE { get; set; }

        public int FK_TYPE { get; set; }

        public byte[] PHOTO { get; set; }

        public string PRICE { get; set; }

    }
}
