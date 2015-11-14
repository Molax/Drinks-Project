using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DrinksProject;
using DrinksProject.Bll;
using DrinksProject.ViewModel;
using System.Collections;

namespace AppOnTime.Web.Controllers
{
    public class SizeController : ApiController
    {
        [HttpPost]
        public List<DrinksProject.ViewModel.SelectAllSizes> SelectAllSizes()
        {
            List<DrinksProject.ViewModel.SelectAllSizes> Sizes = DrinksProject.Bll.Select.SelectAllSizes();

            return Sizes;
     
        }
    }
}
