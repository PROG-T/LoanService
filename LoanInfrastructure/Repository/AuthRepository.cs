using LoanDomain.Entities;
using LoanInfrastructure.DBContext;
using LoanInfrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanInfrastructure.Repository
{
    public class AuthRepository : AuthInterface
    {
        private readonly ApplicationDbContext _context;
        public AuthRepository(ApplicationDbContext Context)
        {
            _context = Context;
        }
        public Task<string> Login(string username, string password)
        {
        }

        public Task<User> Register(User user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
