using BunniesCraft.Data;
namespace BunniesCraft.Data.Repositories
{
    using BunniesCraft.Data.Repositories;
    using BunniesCraft.Model;
    using System;
    using System.Collections.Generic;

    public class BunniesData : IBunniesData
    {
        private IBunniesDbContext context;
        private IDictionary<Type, object> repositories;

        public BunniesData()
            : this(new BunniesDbContext())
        {
        }

        public BunniesData(IBunniesDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }
        public IRepository<Bunny> Bunnies
        {
            get
            {
                return this.GetRepository<Bunny>();
            }
        }


        public IRepository<AirCraft> Aircrafts 
        {
            get
            {
                return this.GetRepository<AirCraft>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }



        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(Repository<T>);

                //if (typeOfModel.IsAssignableFrom(typeof(Student)))
                //{
                //    type = typeof(StudentsRepository);
                //}

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeOfModel];
        }
    }
}
