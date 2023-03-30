using Microsoft.EntityFrameworkCore;
using Nhap.Models;
using Nhap.Models.Account;

namespace Nhap.Data
{
    public class ApplicationContext:DbContext
    {
       
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
            public DbSet<User> Users { get; set; }

        }
    }

