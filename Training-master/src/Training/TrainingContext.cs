using System.Data.Entity;
using Training.Models;

namespace WebApplication1
{

    public partial class TrainingContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }

        public TrainingContext()
            : base("data source=.\\SQLEXPRESS;initial catalog=Project1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

    }
}
