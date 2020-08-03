using BlazorNiliAnswers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Repositories.Implementations
{
    public class PersonRepositoryTwo : IPersonRepository
    {
        public int NextId => throw new NotImplementedException();

        public bool AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeopleByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeopleByRating(double rating)
        {
            throw new NotImplementedException();
        }

        public Person GetPersonByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public Person GetPersonById(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetPersonByLastName(string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
