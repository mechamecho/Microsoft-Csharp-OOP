namespace ClassExample
{
    // Defining Class Members
   class DrinksMachine
    {
        // The following statements define a property with a private field.
        private string _location;
        public string Location
        {
            get => _location;
            set
            {
                if (value != null)
                    _location = value;
            }
        }
        // The following statements define properties.
        public string Make { get; set; }
        public string Model { get; set; }
        public int Age { get; set; }

        //Constructors
        public DrinksMachine(int age)
        {
            this.Age = age;
        }



        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }

        // The following statements define methods.
        public void MakeCappuccino()
        {
            // Method logic goes here.
        }
        public void MakeEspresso()
        {
            // Method logic goes here.
        }
        // The following statement defines an event. The delegate definition is not shown.
        //public event OutOfBeansHandler OutOfBeans;
    }
}
