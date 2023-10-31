namespace InterfacesAndAbstractClasses
{
    public struct Coordinate
    {
        private double x;
        private double y;
        private double z;
        public double X
        {
            get { return x; }
            set
            {
                if (value >= 0)
                {
                    x = value;
                }
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                if (value >= 0)
                {
                    y = value;
                }
            }
        }
        public double Z
        {
            get { return z; }
            set
            {
                if (value >= 0)
                {
                    z = value;
                }
            }
        }
        public Coordinate(double x, double y, double z)
        {
           this.x = x;
           this.x = x;
           this.y = y;
           this.z = z;
        }

        public string PrintCoordinate()
        {
            return $"[{x} : {y} : {z}]";
        }

        public static implicit operator Coordinate(int v)
        {
            throw new NotImplementedException();
        }
    }
}
