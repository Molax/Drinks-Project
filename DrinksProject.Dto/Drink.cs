using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProject.Dto
{
    public class Drink
    {
        public int PK_DINK { get; set; }

        public string NAME { get; set; }

        public byte[] PHOTO { get; set; }

        public int FK_SIZE { get; set; }

        public int FK_TYPE { get; set; }
    }
}
