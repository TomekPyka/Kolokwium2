using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Controllers
{
    [Route("api/firefighters")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        private RemizaContext _remizaContext;


        public ActionsController(RemizaContext remizaContext)
        {
            _remizaContext = remizaContext;
        }

      
        [HttpGet]
        public async Task<IActionResult> GetActionsWithFirefighter([FromQuery(Name = "idFirefighter")] int IdFirefighter)
        {
      
            var actions = await _remizaContext.Actions
                .AsNoTracking()
                .Select(actions => new
                {
                    actions.IdAction,
                    actions.StartTime,
                    actions.EndTime,
                })
                .ToListAsync();

            return Ok(actions);
        }