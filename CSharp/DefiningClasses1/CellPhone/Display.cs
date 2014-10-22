

namespace CellPhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Display
    {
        // Fields
        private double size;
        private int numOfColors;

        // Constructors

        public Display(double size, int numOfColors)
        {
            this.size = size;
            this.numOfColors = numOfColors;
        }

        // Properties
        public int NumOfColors
        {
            get 
            { 
                return this.numOfColors;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colors is always positive");
                }
                this.numOfColors = value;
            }
        }
        public double Size
        {
            get { return this.size; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size is always positive number");
                }
                this.size = value;
            }
        }

        public string DisplayInfo
        { get {return string.Format("  Size {0} inches,  Colors: {1}", this.size, this.numOfColors) ;} }
    }

}
