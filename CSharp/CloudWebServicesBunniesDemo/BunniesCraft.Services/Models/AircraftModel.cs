using BunniesCraft.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BunniesCraft.Services.Models
{
    public class AircraftModel
    {
        public static Expression<Func<AirCraft, AircraftModel>> FromAirCraft
        {
            get
            {
                return a => new AircraftModel
                {
                    Id = a.Id,
                    Model = a.Model
                };
            }
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(3)]
        public string Model { get; set; }
    }
}