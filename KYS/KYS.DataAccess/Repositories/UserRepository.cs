using KYS.DataAccess.Context;
using KYS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYS.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
