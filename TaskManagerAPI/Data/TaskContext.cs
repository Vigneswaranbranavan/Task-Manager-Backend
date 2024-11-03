using Microsoft.EntityFrameworkCore;

namespace TaskManagerAPI.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Login> Logins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserItem>()
                .HasOne(u => u.Address)
                .WithOne(b => b.UserItem)
                .HasForeignKey<Address>(c => c.userId);


            modelBuilder.Entity<UserItem>()
                .HasMany(u => u.Tasks)
                .WithOne(p => p.Assignee)
                .HasForeignKey(c => c.AssigneeId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
