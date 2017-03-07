using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Training.Models
{
    public class Event
    {
        [Key]
        public int idEvent { set; get; }
        public DateTime date { set; get; }
        public TimeSpan time { set; get; }
        public double price { set; get; }
        public string location { set; get; }
        public string name { set; get; }

    }
}
