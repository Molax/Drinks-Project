using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DrinksProject;
using DrinksProject.Bll;
using DrinksProject.ViewModel;

namespace AppOnTime.Web.Controllers
{
    public class SizeController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage SelectAllSizes()
        {
            DrinksProject.ViewModel.SelectAllSizes Sizes = DrinksProject.Bll.Select.SelectAllSizes();

            return Request.CreateResponse(HttpStatusCode.OK);
     
        }
    }
}
