namespace Mod1_Lab2
{
    public class Car
    {

        private static int _instances = 0;

        //Defining Properties 
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car()
        {
            _instances++;
        }

        public Car(string color, int year)

        {
            _instances++;
            this.Color = color;
            this.Year = year;
        }

        public Car(int year, int mileage)
        {
            _instances++;
            this.Year = year;
            this.Mileage = mileage;
        }

        //Declare static member to count number of cars created
        public static int CountCars()
        {
            return _instances;
        }
    }
}
