using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        public TaxaJurosController()
        {
        }

        [HttpGet]
        public ActionResult<double> GetAll() =>
            TaxaJurosService.GetAll();

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}