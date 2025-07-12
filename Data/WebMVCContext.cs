using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shop_asp_net_core_mvc.Models;

namespace shop_asp_net_core_mvc.Data
{
    public class WebMVCContext : DbContext
    {
        public WebMVCContext (DbContextOptions<WebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<shop_asp_net_core_mvc.Models.Department> Department { get; set; } = default!;
    }
}
