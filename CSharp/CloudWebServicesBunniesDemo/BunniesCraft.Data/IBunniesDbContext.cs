using BunniesCraft.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunniesCraft.Data
{
    public interface IBunniesDbContext
    {
        IDbSet<Bunny> Bunnies { get; set; }

        IDbSet<AirCraft> Aircrafts { get; set; }

        void SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
