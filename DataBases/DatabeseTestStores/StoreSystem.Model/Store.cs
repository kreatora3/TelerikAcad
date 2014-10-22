using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreSystem.Model
{
    public class Store
    {
        private ICollection<Employee> employees;

        public Store()
        {
            this.employees = new HashSet<Employee>();
        }
        public int Id { get; set; }

        public int TownId { get; set; }

        public int EmployeeId { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }
    }
}
