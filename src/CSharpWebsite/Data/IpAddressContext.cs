using Microsoft.EntityFrameworkCore;
using CSharpWebsite.Models;

namespace CSharpWebsite.Models {
    public class IpAddressContext : DbContext
    {
        public IpAddressContext(DbContextOptions<IpAddressContext> options) : base(options) { }


        public DbSet<IpAddress> IpAddresses { get; set; }

    }
}
