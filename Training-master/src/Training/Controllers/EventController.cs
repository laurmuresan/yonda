using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Training.Repository;
using System.Collections;
using Training.Models;

namespace Training.Controllers
{
    [Route("api/[controller]")]
    public class EventController : Controller
    {

        // POST api/values
        [HttpGet("allevents")]
        public IEnumerable<Event> getEvents()
        {

            using (RepositoryEvent repo = new RepositoryEvent())
            {
                return repo.GetAllEvents();
            }
        }
    }
}

