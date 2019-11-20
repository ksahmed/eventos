using System;
using Eventos.UserService.Business.Domain;

namespace Eventos.UserService.Repository
{
    public class UserRepository : IUserRepository
    {
        public string Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}