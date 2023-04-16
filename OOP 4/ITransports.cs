using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    internal interface ITransports
    {
        public void Speed();
        public void Fuel();
        public void CostOfTravel();
    }

    class Car : ITransports
    {
        public void Fuel()
        {
            int fuel = 40;
            Console.WriteLine(" liters of fuel" + fuel);
        }
        public void Speed() 
        {
            int speed = 60;
            Console.WriteLine("car of speed " + speed);
        }

        public void CostOfTravel()
        {
            int costoftravel = 2000;
            Console.WriteLine("Cost of Travel: " + costoftravel);
        }
    }

    class Bicycle : ITransports
    {
        public void Fuel()
        {
            throw new System.NotImplementedException();
        }
        public void Speed()
        {
            throw new System.NotImplementedException();
        }

        public void CostOfTravel()
        {
            throw new System.NotImplementedException();
        }
    }

    class Motorcycle : ITransports
    {
        public void Fuel()
        {
            throw new System.NotImplementedException();
        }
        public void Speed()
        {
            throw new System.NotImplementedException();
        }

        public void CostOfTravel()
        {
            throw new System.NotImplementedException();
        }
    }
}
