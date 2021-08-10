﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        
        public Vehicle()
        {
            Year = "2010";
            Make = "Honda";
            Model = "Regular";

        }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Vehicle is driving smoothly");
        }

    }
}
