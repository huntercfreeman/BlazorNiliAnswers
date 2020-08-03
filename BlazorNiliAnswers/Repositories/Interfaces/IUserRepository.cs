using BlazorNiliAnswers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNiliAnswers.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public bool Login(string username, string password);
        public User GetUserByUsername(string username);
        public List<User> GetUsers();
        public List<User> GetUsersByFirstName(string firstName);
        public List<User> GetUsersByLastName(string lastName);
        public List<User> GetUsersByState(string state);
    }
}
