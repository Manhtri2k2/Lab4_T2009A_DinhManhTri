namespace GeometricObjectDemo
{
    public abstract class GeometricObject
    {
        protected string color;
        protected double weight;

        protected GeometricObject()
        {
            color = "white";
            weight = 1.0;
        }

        protected GeometricObject(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }

        public string PColor
        {
            get { return color; }
            set { color = value; }
        }
        
        public double PWeight
        {
            get => weight;
            set => weight = value;
        }

        public abstract double findArea();

        public abstract double findPerimeter();
    }
}