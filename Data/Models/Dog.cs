using System;

namespace Data.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age => DateTime.Today.Year - Birthdate.Year;
    }
}