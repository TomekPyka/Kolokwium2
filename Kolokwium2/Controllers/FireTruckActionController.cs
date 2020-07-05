using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.DAL;
using Kolokwium2.DTO.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers
{
    [Route("api/actions")]
    [ApiController]
    public class FireTruckActionController : ControllerBase
    {

        private RemizaContext _remizaContext;


        public FireTruckActionController(RemizaContext remizaContext)
        {
            _remizaContext = remizaContext;
        }


        [HttpPost("{IdAction}/fire-trucks")]
        public async Task<IActionResult> Post(int IdAction, [FromBody] NewActionRequest request)
        {
            var action = await _remizaContext.Actions.FindAsync(IdAction);




            return Ok();
        }
    } 
}