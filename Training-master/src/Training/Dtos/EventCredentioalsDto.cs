using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Training.Dtos
{
    public class EventCredentialsDto
    {
        public int idEvent { set; get; }
        public DateTime date { set; get; }
        public float price { set; get; }
        public string location { set; get; }
        public string name { set; get; }
    }
}

