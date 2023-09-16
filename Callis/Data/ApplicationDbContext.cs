using Callis.Models;
using Microsoft.EntityFrameworkCore;

namespace Callis.Data;

    public class ApplicationDbContext: DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }

    public DbSet<Models.Task> Tasks { get; set; }
    public DbSet<AccountType> AccountTypes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Models.TaskStatus> TaskStatuses { get; set; }
}

