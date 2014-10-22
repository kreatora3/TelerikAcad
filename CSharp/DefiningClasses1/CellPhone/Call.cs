

namespace CellPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Call
    {
        // Fields
        private DateTime date;
        private string dialedNumber;
        private int duration;

        // Constructor

        public Call(DateTime date, string dialedNumber, int duration) 
        {
            this.Date = date;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }
        
        // Properties
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        
        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }
        
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        
        // Methods

        public override string ToString()
        {
            StringBuilder callInfo = new StringBuilder();
            
            callInfo.AppendLine(string.Format("Call started on {0}\n at {1}", this.Date.ToShortDateString(), this.Date.ToLongTimeString()));
            callInfo.AppendLine(string.Format("Dialed number: {0}", this.DialedNumber));
            callInfo.AppendLine(string.Format("Call duration: {0} min {1} sec", this.Duration / 60, this.Duration % 60));
            
            return callInfo.ToString();
        }
    }
}
