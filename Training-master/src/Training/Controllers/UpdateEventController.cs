using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training.Models;
using Training.Dtos;
using Training.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Training.Controllers
{
    [Route("api[controller]")]
    public class UpdateEventController : Controller
    {
        [HttpPost("updateevent")]
        public Event UpdateEvent([FromBody]EventCredentialsDto value)
        {
            Event eve = new Event();
            eve.idEvent = value.idEvent;
            eve.date = value.date;
            eve.price = value.price;
            eve.location = value.location;
            eve.name = value.name;

            using (RepositoryUpdateEvent repo = new RepositoryUpdateEvent())
            {
                repo.UpdateEvent(eve);
            }

            return eve;
        }
    }
}
