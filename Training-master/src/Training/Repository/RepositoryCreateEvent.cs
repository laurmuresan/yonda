using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1;
using Training.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Training.Repository
{
    public class RepositoryCreateEvent : IDisposable
    {
        private TrainingContext trainingContext;

        public RepositoryCreateEvent()
        {
            trainingContext = new TrainingContext();
        }

        public void Dispose()
        {
            if(trainingContext != null)
            {
                trainingContext.Dispose();
            }
        }
        public void  AddEvent(Event eve)
        {
            trainingContext.Events.Add(eve);
            trainingContext.SaveChanges();                        
        }     
    }

}