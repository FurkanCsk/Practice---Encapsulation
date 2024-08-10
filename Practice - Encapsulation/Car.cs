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

        public Car()
        {

        }

        public Car(string brand, string model, string color, int doorNum)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorNum = doorNum;
        }

        public void DisplayCar()
        {
            Console.WriteLine($"Car Brand : {_brand}\nCar Model : {_model}\nCar Color : {_color}\nDoor Number : {_doorNum}\n");
        }
    }
}
