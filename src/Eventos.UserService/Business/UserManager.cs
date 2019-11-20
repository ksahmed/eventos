using Eventos.UserService.Contracts;
using DomainUser = Eventos.UserService.Business.Domain.User;
using Eventos.UserService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;

namespace Eventos.UserService.Business
{
    public class UserManager
    {
        private readonly IUserRepository _repo;

        public UserManager(IUserRepository repo)
        {
            _repo = repo;
        }

        public string Authenticate(string username, string password)
        {
            return _repo.Authenticate(username, password);
        }

        public void Register(User user)
        {
            _repo.Register(user.Adapt<DomainUser>());
        }
    }
}