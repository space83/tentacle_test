using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.DBContexts;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Model.Transaction.ResponseMessage> Register(CdnUser user)
        {
            var results = new Model.Transaction.ResponseMessage();

            try
            {                
                results.result = UserService.InsertUser(user);
            }
            catch (Exception ex)
            {
                results.result = false;
                results.resultmessage = ex.Message;
            }

            return Ok(results);
        }

        [HttpGet]
        public ActionResult<List<CdnUser>> Get()
        {
            var results = new List<CdnUser>();

            try
            {
                results = UserService.GetUsers();
            }
            catch (Exception ex)
            {
               
            }

            return results;
        }

        [HttpPut]
        public ActionResult<Model.Transaction.ResponseMessage> UpdateUser(CdnUser user)
        {
            var results = new Model.Transaction.ResponseMessage();

            try
            {
                results.result = UserService.UpdateUser(user);
            }
            catch (Exception ex)
            {
                results.result = false;
                results.resultmessage = ex.Message;
            }

            return Ok(results);
        }

        [HttpDelete]
        public ActionResult<Model.Transaction.ResponseMessage> DeleteUser(Guid userid)
        {
            var results = new Model.Transaction.ResponseMessage();

            try
            {
                results.result = UserService.DeleteUser(userid);
            }
            catch (Exception ex)
            {
                results.result = false;
                results.resultmessage = ex.Message;
            }

            return Ok(results);
        }


    }
}
