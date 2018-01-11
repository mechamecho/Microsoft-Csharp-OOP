using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class DrinksMachineProperties
    {
        // private member variables
        private int _age;
        private string _make;

        //auto implemented property
        public string Name { get; set; }

        // public properties
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        // auto-implemented property
        public string Model { get; set; }

        // Constructors
        public DrinksMachineProperties(int age)
        {
            this.Age = age;
        }
        public DrinksMachineProperties(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public DrinksMachineProperties(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }
    }
}
