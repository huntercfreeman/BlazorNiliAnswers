using BlazorNiliAnswers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Repositories
{
    public interface IPersonRepository
    {
        public List<Person> GetPeople();
        public Person GetPersonByFirstName(string firstName);
        public Person GetPersonByLastName(string lastName);
        public List<Person> GetPeopleByRating(double rating);
        public Person GetPersonById(int id);
        public bool AddPerson(Person person);
        public List<Person> GetPeopleByFirstName(string firstName);
        public int NextId { get; }
    }
}
