using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fansoft.Catalog.API.Controllers
{
    public class TesteController : ControllerBase
    {
        [HttpGet("ping")]
        public string Ping() => "Pong";

        [HttpGet("object")]
        public JsonResult TesteObject()
        {
            return new JsonResult(
                new List<object>{
                    new {id = 1, name = "Daniboy"},
                    new {id = 1, name = "Daniboy"},
                    }

            );

        }
    }
}
