using BunniesCraft.Data.Repositories;
using BunniesCraft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BunniesCraft.Services.Models;
using BunniesCraft.Data;

namespace BunniesCraft.Services.Controllers
{
    public class AircraftsController : ApiController
    {
        private IBunniesData data;
        public AircraftsController()
            : this(new BunniesData())
        {

        }

        public AircraftsController(IBunniesData data)
        {
            this.data = data;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var aircrafts = this.data.Aircrafts.All().Select(AircraftModel.FromAirCraft);
           
            return Ok(aircrafts);
        }

        [HttpPost]
        public IHttpActionResult Create(AircraftModel aircraft)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAircraft = new AirCraft
            {
                Model = aircraft.Model
            };

            this.data.Aircrafts.Add(newAircraft);
            this.data.SaveChanges();
            
            aircraft.Id = newAircraft.Id;

            return Ok(aircraft);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, AircraftModel aircraft)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingAircraft = this.data.Aircrafts.All().FirstOrDefault(a => a.Id == id);
            if (existingAircraft == null)
            {
                return BadRequest("Such aircraft does not exist");
            }

            existingAircraft.Model = aircraft.Model;
            this.data.SaveChanges();
            aircraft.Id = existingAircraft.Id;
            return Ok(aircraft);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingAircraft = this.data.Aircrafts.All().FirstOrDefault(a => a.Id == id);
            if (existingAircraft == null)
            {
                return BadRequest("Nothing to delete");
            }

            this.data.Aircrafts.Delete(existingAircraft);
            this.data.SaveChanges();

            return Ok();
        }

        [HttpPut]

        public IHttpActionResult AddBunny(int id, int bunnyId)
        {
            var airCraft = this.data.Aircrafts.All().FirstOrDefault(a => a.Id == id);
            if (airCraft == null)
            {
                return BadRequest("No such aircraft");
            }

            var bunny = this.data.Bunnies.All().FirstOrDefault(b => b.Id == bunnyId);
            if (bunny == null)
            {
                return BadRequest("No such bunny exists");
            }

            airCraft.Bunnies.Add(bunny);
            data.SaveChanges();
            return Ok();
        }
    }
}
