using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Vehicle
    {
        public string strType;
        public string strColor;
        public double dblSpeed;
        public string strBrand;
        public virtual void Run()
        {
            Console.WriteLine(strType + "    : I am running");
        }
        public void Display()
        {
            Console.WriteLine("Type : " + strType);
            Console.WriteLine("Color : " + strColor);
            Console.WriteLine("Speed : " + dblSpeed);
            Console.WriteLine("Brand : " + strBrand);
        }
    }

    class Car : Vehicle
    {
        public Car (Vehicle objVehicle)
        {
            strType = objVehicle.strType;
            strColor = objVehicle.strColor;
            dblSpeed = objVehicle.dblSpeed;
            strBrand = objVehicle.strBrand;
        }

        public override void Run()
        {
            Console.WriteLine("The CAR is running");
        }
    }
    class Inherit
    {
        static void Main(string[] args)
        {
            Vehicle objVehicle = new Vehicle();
            objVehicle.strType = "Car";
            objVehicle.strColor = "Color";
            objVehicle.dblSpeed = 100.2;
            objVehicle.strBrand = "BMW";
            Car objCar = new Car(objVehicle);
            objCar.Run();
            objCar.Display();
        }
    }
}
