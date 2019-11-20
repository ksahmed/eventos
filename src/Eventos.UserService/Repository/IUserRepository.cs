using Eventos.UserService.Business.Domain;
using Eventos.UserService.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos.UserService.Repository
{
    public interface IUserRepository
    {
        public string Authenticate(string username, string password);

        public void Register(Business.Domain.User user);
    }
}