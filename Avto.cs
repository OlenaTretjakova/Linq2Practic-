using System;

namespace Linq2Practicу
{
    public class Auto
    {
        public string Name { get; set; }
        public DateTime YearCreated { get; set; }
        public string Producer { get; set; }

        public Auto(string name, DateTime yearCreated, string producer)
        {
            Name = name;
            YearCreated = yearCreated;
            Producer = producer;
        }

        public override string ToString()
        {
            return $"{Name}, {YearCreated}, {Producer}";
        }
    }
}
