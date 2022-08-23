using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTask
{
    class Room
    {
        public readonly int _id;
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool isAvailable { get; set; } = true;

        public Room(int Id, string Name, double Price, int PersonCapacity, bool IsAvailable)
        {
            Id = _id;
            Name = Name;
            Price = Price;
            PersonCapacity = PersonCapacity;
            IsAvailable = isAvailable;
        }
        public Room()
        {
            _id++;
            _id = _id;
        }
        public string ShowInfo()
        {
            return ("Room name: " + Name + "\nRoom price: " + Price + "\nRoom person capacity: " + PersonCapacity + "\nRoom is aviable: " + isAvailable);
        }
        public override string ToString()
        {
            return ShowInfo();
        }


    }
}