﻿using System.Collections.Generic;

namespace Raw_Data
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo Cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = Cargo;
            Tires = tires;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }
    }
}