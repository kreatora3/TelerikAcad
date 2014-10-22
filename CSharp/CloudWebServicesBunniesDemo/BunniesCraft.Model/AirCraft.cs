namespace BunniesCraft.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class AirCraft
    {
        private ICollection<Bunny> bunnies;

        public AirCraft()
        {
            this.bunnies = new HashSet<Bunny>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(3)]
        public string Model { get; set; }

       // public int BunnyId { get; set; }

        public virtual ICollection<Bunny> Bunnies // корабът има много зайци !
        {
            get { return this.bunnies; }
            set { this.bunnies = value; }
        }
    }
}
