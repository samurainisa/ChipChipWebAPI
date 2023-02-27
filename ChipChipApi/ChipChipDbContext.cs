
using ChipChipApi.Confurations;
using ChipChipApi.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
namespace ChipChipApi
{
    public class ChipChipDbContext : DbContext
    {

        public ChipChipDbContext()
        {
        }

        public ChipChipDbContext(DbContextOptions<ChipChipDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
