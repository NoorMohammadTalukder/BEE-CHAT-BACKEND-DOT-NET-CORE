using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice.Context;
using Practice.Models;

namespace Practice.Controllers
{
  

    // [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApplicationDbContext _dbContext;
        public UserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
          
        }
        [EnableCors()]

        [Route("api/create/user")]
        [HttpPost]
        public ActionResult<User> Add(User obj)
        {
            try
            {

              _dbContext.Users.Add(obj);
              _dbContext.SaveChanges();
              return Created("Created", obj);
                
                
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors()]

        [Route("api/all/user")]
        [HttpGet]
        public ActionResult<User> GetAll()
        {
            try
            {
                var users = _dbContext.Users.ToList();
                if (users == null)
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [EnableCors()]

        [Route("api/login/user/{Email}")]
        [HttpPost]
        public ActionResult<User> Login(string Email)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(e => e.Email == Email);
                return Ok(user);

            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [EnableCors()]
        [Route("api/get/login/user/{Email}")]
        [HttpGet]
        public ActionResult<User> GetLoginUser(string Email)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(e => e.Email == Email);
                return Ok(user);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors()]
        [Route("api/create/messsage/user")]
        [HttpPost]
        public ActionResult<User> CreateMesssage(Conversation obj)
        {
            try
            {

                _dbContext.Conversations.Add(obj);
                _dbContext.SaveChanges();
                return Created("Created", obj);


            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [EnableCors()]

        [Route("api/all/coversation/{id1}/{id2}")]
        [HttpGet]
        public ActionResult <User> Messages(int id1,int id2)
        {
            try
            {
                var data = _dbContext.Conversations.ToList();
                var messges = (from i in data
                               where (i.UserId == id1 || i.UserId2 == id1) && (i.UserId == id2 || i.UserId2 == id2)

                               select i).ToList();
                if (messges == null)
                {
                    return NotFound();
                }
                return Ok(messges);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }


        }
        [EnableCors()]

        [Route("api/delete/chat/{id}")]
        [HttpGet]
        public ActionResult<Conversation> DeleteChat(int id)
        {
            try
            {
               var x= _dbContext.Conversations.FirstOrDefault(e => e.Id == id);
                _dbContext.Conversations.Remove(x);
                _dbContext.SaveChanges();
                return Ok();

            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
