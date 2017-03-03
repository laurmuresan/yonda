using System;
using System.Linq;
using Training.Models;
using WebApplication1;

namespace Training.Repository
{
    public class RepositoryUser : IDisposable
    {
        private TrainingContext trainingContext;

        public RepositoryUser()
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

        public User GetUser(string username, string password)
        {
            return trainingContext.Users.FirstOrDefault(u => u.username.Equals(username) && u.password.Equals(password));
        }
    }
}
