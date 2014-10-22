namespace CellPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Battery
    {
        // Fields

        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;

        // Constructors

        public Battery(string model, BatteryType type, double hoursIdle = 0, double hoursTalk = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }       

        // Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double HoursIdle
        {
            get 
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery hours idle must be positive number");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get 
            { 
                return this.hoursTalk; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery hours talk must be positive number");
                }
                if (value > this.hoursIdle)
                {
                    throw new ArgumentException("Talk hours are always less than idle ones");
                }
                this.hoursTalk = value;
            }
        }

        public string BatteryInfo
        {
            get {return string.Format("  Model {0}, Hours idle {1}, Hours talk {2}", this.model , this.hoursIdle , this.hoursTalk) ;}
        }
        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
