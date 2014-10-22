using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Model
{
    public class Town
    {
        private ICollection<Store> stores;

        public Town()
        {
            this.stores = new HashSet<Store>();
        }
     
        public int Id { get; set; }
        public string Name { get; set; }

        public int StoreId { get; set; }

        public ICollection<Store> Stores
        {
            get
            {
                return this.stores;
            }
            set
            {
                this.stores = value;
            }
        }
    }
}
