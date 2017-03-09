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
    public class RepositoryUpdateEvent : IDisposable
    {
        private TrainingContext trainingContext;

        public RepositoryUpdateEvent()
        {
            trainingContext = new TrainingContext();
        }
        public void Dispose()
        {
            if (trainingContext != null)
            {
                trainingContext.Dispose();
            }
        }

        public void UpdateEvent(Event entity)
        {
            trainingContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            trainingContext.SaveChanges();
        }
    }
}
