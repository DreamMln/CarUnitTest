using System;
using System.Data;

namespace ClassLibraryTests
{
    public class Car
    {
        public int ID { get; set; }
        private static int _nextID = 1;

        private string _model;
        private double _price;
        private string _licensePlate;

        public string Model
        {
            get { return _model; }
            set
            {
                if (value.Length >= 4)
                {
                    _model = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Error! The Model name needs to be at least 4 charcters long!");
                }
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Error! The price needs to be more than 0!");
                }
            }
        }

        public string LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                if (value.Length >= 2 && value.Length <= 7)
                {
                    _licensePlate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Error! The length of the license plate needs to be between 2 and 7");
                }
            }
        }

        public Car()
        {
            //default
        }

        public Car(string model, double price, string licensePlate)
        {
            ID = _nextID++;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }
    }
}

