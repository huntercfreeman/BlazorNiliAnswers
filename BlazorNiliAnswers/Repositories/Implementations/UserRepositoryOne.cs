using BlazorNiliAnswers.Models;
using BlazorNiliAnswers.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Repositories.Implementations
{
    public class UserRepositoryOne : IUserRepository
    {
        public User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByLastName(string lastName)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsersByState(string state)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
