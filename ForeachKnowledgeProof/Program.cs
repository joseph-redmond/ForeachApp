using ForeachKnowledgeProofLibrary.Models;
using System;
using System.Collections.Generic;

namespace ForeachKnowledgeProof
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>() {
            new PersonModel("Joe", "redmond"),
            new PersonModel("Jim", "kile"),
            new PersonModel("Jack", "klanc"),
            new PersonModel("Janet", "lord"),
            new PersonModel("Joely", "clongle"),
        };
        
            foreach(var person in people)
            {
                Console.WriteLine($"{person.FullName}");
            }
            Console.ReadLine();
        }
    }
}
