using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Articles.Data;
namespace Articles.WebApi.Controllers
{
    public class BaseController : ApiController
    {
        protected IArticlesData data;

        public BaseController(IArticlesData data)
        {
            this.data = data; 
        }
    }
}
