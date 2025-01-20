using LoanDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInfrastructure.Interfaces
{
    public interface AuthInterface
    {
        Task<User> Register(User user, string password);
        Task<string> Login(string username, string password);
    }
}
