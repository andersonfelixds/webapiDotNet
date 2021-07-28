using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowmeTheCodeController : ControllerBase
    {
        public ShowmeTheCodeController()
        {
        }

        [HttpGet]
        public ActionResult<string> GetAll() =>
            ShowmeCodeService.Get();

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}