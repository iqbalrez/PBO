using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCarOOP
{
    class Vehicle
    {

        // attribute, field, variables
        string brand;
        string model;
        double horsePower;

        
        bool isTurbo;


        // function, method, procedure, behavior

        // constructor
        public Vehicle(string brand, string model, double hp)
        {
            this.brand = brand;
            this.model = model;
            horsePower = hp;
        }

        // ini procedure
        public void ShowVehicleInformation()
        {
            Console.WriteLine("{0} - {1} that has {2} HP", brand, model, horsePower);
        }

        // ini function 
        public double CalculateOptimumVelocity(double horsePower)
        {
            double velocity = 0;
            // velocity non turbo
            velocity = (horsePower/ 4) * 1.5 + 100;

            // velocity turbp 
            // velocity = velocity + 0.1 * velocity;


            return velocity;
        }
    }
}
