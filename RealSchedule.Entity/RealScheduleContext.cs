using RealSchedule.Domain.Models;
using System.Data.Entity;

namespace RealSchedule.Entity
{
    public class RealScheduleContext : DbContext
    {
        public RealScheduleContext() : base("RealScheduleContext")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
