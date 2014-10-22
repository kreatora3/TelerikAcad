using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class Article
    {
        private ICollection<Tag> tags;
        private ICollection<Comment> comments;
        private ICollection<Like> likes;

        public Article()
        {
            this.tags = new HashSet<Tag>();
            this.comments = new HashSet<Comment>();
            this.likes = new HashSet<Like>();
        }
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }    // Тук ID-то е стринг !!!!

        public virtual ApplicationUser Author { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }


        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Like> Likes { get; set; }

    }
}
