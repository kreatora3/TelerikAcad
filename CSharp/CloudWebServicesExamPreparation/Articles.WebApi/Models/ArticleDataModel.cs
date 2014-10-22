using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Articles.WebApi.Models
{
    public class ArticleDataModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public DateTime DateCreated { get; set; }
        public ICollection<TagDataModel> Tags { get; set; }
    }
}