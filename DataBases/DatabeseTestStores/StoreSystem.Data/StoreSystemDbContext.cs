using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Model;


namespace StoreSystem.Data
{
    public class StoreSystemDbContext :DbContext
    {
        public StoreSystemDbContext()
            : base("StoreSystem")
        {

        }

        public IDbSet<Town> Towns { get; set; }
        public IDbSet<Store> Stores { get; set; }
        public IDbSet<Employee> Employees { get; set; }
    }
}
