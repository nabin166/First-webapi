using Domain;
using Microsoft.AspNetCore.Mvc;
using Service.AddInterface;




namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly Iitnerface iinterface;

        public UserController(Iitnerface iinterface)
        {
            this.iinterface = iinterface;
        }

        [HttpGet]
        [Route("getall")]

        public IActionResult GetAllRepo()
        {
            var response = this.iinterface.GetAllRepo();
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetsingleRepo(int userid)
        { 
            var response = this.iinterface.GetsingleRepo(userid);
            return Ok(response);

        }

        [HttpPost("add") ]
          public IActionResult Adduser(User user)
        {
          return Ok(this.iinterface.AddUserRepo(user));
        }

        [HttpDelete]
        public IActionResult Removeuser(int Userid)
        {
            return Ok(this.iinterface.DeleteUserRepo(Userid));
        }

        //update
        [HttpPut]
        public IActionResult Updateuser(User user)
        {
            return Ok(this.iinterface.UpdateuserRepo(user));
        }





    }
}
