using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Encapsulation
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _doorNum;

        // Property for accessing and modifying the _brand field.
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        // Property for accessing and modifying the _model field.
        public string Model 
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        // Property for accessing and modifying the _color field.
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        // Property for accessing and modifying the _color field.
        public int DoorNum
        {
            get
            {
                return _doorNum;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorNum = value;
                }
                else
                {
                    Console.WriteLine("The car can have only 2 or 4 door.The door number was set to -1 ");
                    _doorNum = -1;
                }

            }
        }

        // Default Constructor, initializes a new instance of the Car class.
        public Car()
        {

        }

        // Initialize a new instance of the Car class with specified values
        public Car(string brand, string model, string color, int doorNum)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorNum = doorNum;
        }

        // Mehthod that displays the car's informations, including its brand, model, color and door count.
        public void DisplayCar()
        {
            Console.WriteLine($"Car Brand : {_brand}\nCar Model : {_model}\nCar Color : {_color}\nDoor Number : {_doorNum}\n");
        }
    }
}
