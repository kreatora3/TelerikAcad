namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string secondName, double salary, double hoursPerday)
            :base(firstName, secondName)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hoursPerday;
        }

        public double WeekSalary { get; private set; }

        public double WorkHoursPerDay { get; private set; }

        public double MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5.0);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}  earns {2:C} per hour", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
