using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T24_API_NET_Core_2.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
