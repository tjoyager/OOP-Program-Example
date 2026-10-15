
namespace InterfaceBasedSorter
{
    class Car : ISortable
    {
        public string Brand { get; set; }
        public int TopSpeed { get; set; }

        public Car(string brand, int speed)
        {
            Brand = brand;
            TopSpeed = speed;
        }

        public int CompareTo(ISortable other)
        {
            Car otherCar = (Car)other;

            if (this.TopSpeed > otherCar.TopSpeed)
                return -1; // karena ingin sorting descending
            else if (this.TopSpeed < otherCar.TopSpeed)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"Car(Brand: {Brand}, Speed: {TopSpeed})";
        }
    }
}
