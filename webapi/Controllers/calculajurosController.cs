using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class calculajurosController : ControllerBase
    {
        public calculajurosController()
        {
        }

       [HttpGet("{valorInicial},{meses}")]
        public ActionResult<double> Get(double valorInicial, int meses)
        {
            var valorFinal = calculajurosService.Get(valorInicial, meses);

            //if(valorFinal == null)
              //  return NotFound();

            return valorFinal;
        }
        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}