using Articles.Data;
using Articles.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Articles.WebApi.Controllers
{
    public class ArticleController : BaseController
    {
        public ArticleController(IArticlesData data)
            : base(data)
        {

        }
        [HttpPost]
        public IHttpActionResult Create(ArticleDataModel model)
        {

            return Ok();
        }

        [HttpGet]

        public IHttpActionResult Get()
        {
            var articles = this.data.Articles.All();

            return Ok(articles);
        }
    }
}
