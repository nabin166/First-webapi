using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repo;
using Service.AddInterface;

namespace Service.Implements 
{
    public class Userservice : Iitnerface
    {
        private readonly Contextclass dbContext;

        public Userservice(Contextclass DbContext)
        {
            dbContext = DbContext;
        }



        public string AddUserRepo(User user)
        {
          this.dbContext.Users.Add(user);
            this.dbContext.SaveChanges();
            return "successfully added";
        }

        public string DeleteUserRepo(int userid)
        {
            var users = this.dbContext.Users.Find(userid);
            this.dbContext.Users.Remove(users);
            this.dbContext.SaveChanges();
            return "Successfully removed";
        }

        public List<User> GetAllRepo()
        {
            return this.dbContext.Users.ToList();
        }

        public User GetsingleRepo(int userid)
        {
            return this.dbContext.Users.Find(userid);
        }

        public string UpdateuserRepo(User user)
        {
            var username = this.dbContext.Users.Find(user.Id);
            if(username != null)
            {
                username.Name = user.Name;
                return "success";
            }
            else
            {
                return "no record found";
            }
          

        }
    }
}
