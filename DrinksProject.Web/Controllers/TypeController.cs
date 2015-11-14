using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppOnTime.Web.Controllers
{
    public class TypeController : ApiController
    {
        [HttpPost]
        public List<DrinksProject.ViewModel.SelectAllTypes> SelectAllTypes()
        {
            List<DrinksProject.ViewModel.SelectAllTypes> Types = DrinksProject.Bll.Select.SelectAllTypes();

            return Types;

        }
    }
}
