using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1;
using Training.Models;

namespace Training.Repository
{
    public class RepositoryEvent : IDisposable
    {
        private TrainingContext trainingContext;

        public RepositoryEvent()
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
        public IEnumerable<Event> GetEvent()
        {
            return trainingContext.Event;
        }
    }


}

