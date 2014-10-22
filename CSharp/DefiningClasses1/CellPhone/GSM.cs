
namespace CellPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GSM
    {
        // Fields
        private const decimal PricePerMin = 0.37m;
        private static readonly GSM iPhone4S = new GSM("IPhone4S", "Apple", "Pesho", 1000, new Battery("iphoneBat", BatteryType.LiIon, 500, 12), new Display(5.0, 40000000));  // Static field

        private string model;
        private string manifacturer;
        private string owner;
        private int price;
        private List<Call> callHistory;
        private Battery battery;
        private Display screen ;
       
        // Constructors
        public GSM(string model, string manifacturer, string owner = "", int price = 0, Battery battery = null, Display screen= null)                                                                                                      
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Owner = owner;
            this.Price = price;
            this.callHistory = new List<Call>();
            this.battery = battery;
            this.screen = screen;
        }

          /*This is the same as the commented constructor bellow,
          but made with just 1 constructor instead of 2 and using of :this*/

        // public GSM(string model, string manifacturer)
        //    : this(model, manifacturer, null, 0)
        // {
        // }

        // public GSM(string model, string manifacturer, string owner, uint price)
        // {
        //    this.model = model;
        //    this.manufacturer = manifacturer;
        //    this.owner = owner;
        //    this.price = price;
        // }
       
        // Proerties

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manifacturer
        {
            get 
            { 
                return this.manifacturer;
            }

            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("The name of the manifacturer should start with upper case.");
                }

                this.manifacturer = value;
            }
        }

        public int Price
        {
            get 
            { 
                return this.price; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Only positive numbers are allowed to set the price");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get 
            {
                return this.owner; 
            }

            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("The name of the owner should start with upper case.");
                }

                this.owner = value;
            }
        }
        public List<Call> CallHistory
        {
            get { return new List<Call>(this.callHistory); }
            private set { this.callHistory = value; }
        }
        // Methods
        public override string ToString()   // Overriding ToString()
        {
            return this.manifacturer + " " + this.model + "\n" + "Owner:" + " " + this.owner + "\n" + "Price:" + " " + this.price + "\n" + "Battery:" + this.battery.BatteryInfo + "\n" + "Display:" + this.screen.DisplayInfo ;
        }

        public void AddCalls(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(int position)
        {
            this.callHistory.RemoveAt(position);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal PhoneBill(decimal price = PricePerMin)
        {
            decimal bill = 0m;
           
            foreach (var call in this.callHistory)
            {
                bill += call.Duration * price / 60;
            }
           
            return bill;

        }

        public void PrintCallHistory()
        {
            Console.WriteLine("***Call history***");
            Console.WriteLine();
            if (this.callHistory.Count > 0)
            {
                
                foreach (Call call in this.callHistory)
                {
                    Console.WriteLine(call);
                }
            }
            else
            {
                Console.WriteLine("Is Empty");
            }
            
        }

    }

}
