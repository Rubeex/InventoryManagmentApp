using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AplicationDbContext>
    {

        public AplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",
                 optional: true, reloadOnChange: true);
            var Configuration = builder.Build();

            var ConnectionStrings = Configuration.GetConnectionString("DefaultConnections");

            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings);

            return new AplicationDbContext(optionsBuilder.Options);
        }
    }
}
