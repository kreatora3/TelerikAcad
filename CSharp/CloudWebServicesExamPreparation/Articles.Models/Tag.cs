﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Articles.Models
{
   public  class Tag
    {
       private ICollection<Article> articles;

       public Tag()
       {
           this.articles = new HashSet<Article>();
       }
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
