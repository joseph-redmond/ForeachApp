using System;
using System.Collections.Generic;
using System.Text;

namespace ForeachLibrary.Models
{
    public class PersonModel
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
