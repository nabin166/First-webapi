using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AddInterface
{
   public interface Iitnerface
    {
        List<User> GetAllRepo();

        User GetsingleRepo(int userid);
        string AddUserRepo(User user);
        string UpdateuserRepo(User user);

        string DeleteUserRepo(int userid);
    }
}
