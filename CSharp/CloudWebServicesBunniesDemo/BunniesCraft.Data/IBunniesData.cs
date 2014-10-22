using BunniesCraft.Data.Repositories;
using BunniesCraft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BunniesCraft.Data
{
    public interface IBunniesData
    {
       IRepository<Bunny> Bunnies { get; }

       IRepository<AirCraft> Aircrafts { get; }

       void SaveChanges();        
    }
}
