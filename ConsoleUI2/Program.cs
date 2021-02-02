﻿using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
