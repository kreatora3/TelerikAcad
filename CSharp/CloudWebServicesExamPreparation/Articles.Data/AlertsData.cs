using Articles.Data.Repositories;
using Articles.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Data
{
   public  class AlertsData
    {
       private Dictionary<Type, object> repositories;
       private DbContext context;

       public AlertsData(ArticlesDbContext context)
       {
           this.context = context;
           this.repositories = new Dictionary<Type, object>();
       }

       public IRepository<Alert> Alerts
       {
           get { return this.GetRepository<Alert>(); }    // Това е различно за вс проект -> репозитори за вс ентити
       }


       private IRepository<T> GetRepository<T>() where T : class
       {
           var typeOfRepository = typeof(T);
           if (!this.repositories.ContainsKey(typeOfRepository))
           {
               var newReposiotry = Activator.CreateInstance(typeof(Repository<T>), context);
               this.repositories.Add(typeOfRepository, newReposiotry);
           }

           return (IRepository<T>)this.repositories[typeOfRepository];
       }
    }
}
