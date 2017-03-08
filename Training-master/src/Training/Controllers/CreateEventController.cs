using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Training.Dtos;
using Training.Models;
using Training.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Training.Controllers
{
    [Route("api/[controller]")]
    public class CreateEventController : Controller
    {
        [HttpPost("allevents")]
        public Event CreateEvent ([FromBody]EventCredentialsDto value)
        {
            Event eve = new Event();
            eve.date = value.date;
            eve.time = value.time;
            eve.price = value.price;
            eve.location = value.location;
            eve.name = value.name;

            using (RepositoryCreateEvent repo = new RepositoryCreateEvent())
            {
               repo.AddEvent(eve);
            }

            return eve;
        }
    }
}
