using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4
{
    internal interface IConsoleApp
    {
        void Name();
        void Salary();
        void VacationDays();
    }

    class Proqraming : IConsoleApp
    {

        public void Name()
        {
            Console.WriteLine("Adil");
        }

        public void Salary()
        {
            int salary = 5000;
            Console.WriteLine(salary);
        }

        public void VacationDays()
        {
            Console.WriteLine("alti bazar istirahet ve gunde sadece 3-4 saat ishleyir");
        }
    }

    class Design : IConsoleApp
    {

        public void Name()
        {
            Console.WriteLine("Leman");
        }

        public void Salary()
        {
            int salary = 2000;
            Console.WriteLine(salary);
        }

        public void VacationDays()
        {
            Console.WriteLine("alti bazar istirahet");
        }
    }

    class Manager : IConsoleApp
    {

        public void Name()
        {
            Console.WriteLine("Rustem");
        }

        public void Salary()
        {
            int salary = 1600;
            Console.WriteLine(salary);
        }

        public void VacationDays()
        {
            Console.WriteLine("alti bazar istirahet");
        }
    }
}

