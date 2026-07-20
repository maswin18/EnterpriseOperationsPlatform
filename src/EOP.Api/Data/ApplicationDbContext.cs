using Microsoft.EntityFrameworkCore;
using EOP.Api.Models;

namespace EOP.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Store> Stores => Set<Store>();
}