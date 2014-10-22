namespace BunniesCraft.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;
    public class Bunny
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string Name { get; set; }

        [Range(0, 100)]
        public double Health { get; set; }

        public int? AirCraftID { get; set; }     // заека има кораб 

        public virtual AirCraft Aircraft { get; set; }

        [Required]
        public ColorType ColorType { get; set; }
    }
}
