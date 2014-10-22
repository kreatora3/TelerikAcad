namespace Shape
{
    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {       
            get { return this.height; }
            private set { this.height = value; } 
        }

        public double Width
        {
            get { return this.width; }

            private set { this.width = value; }
        }

        public abstract double CalculateSurface();
    }
}
