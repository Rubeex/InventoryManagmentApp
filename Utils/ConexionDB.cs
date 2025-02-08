using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentApp.Utils
{
    public static class ConexionDB
    {

        public static AplicationDbContext InitializeContext()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",
                optional: true, reloadOnChange: true);
            var Configuration = builder.Build();

            var ConnectionStrings = Configuration.GetConnectionString("DefaultConnections");

            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings);

            return new AplicationDbContext(optionsBuilder.Options);
        }

        public static Boolean TestConnection(AplicationDbContext context)
        {
            try
            {
                context.Database.OpenConnection();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al probar la conexión: {ex.Message}");
                return false;
            }
            finally
            {
                // Asegurar que la conexión sea cerrada, incluso si hay errores
                if (context.Database.GetDbConnection().State == System.Data.ConnectionState.Open)
                {
                    context.Database.CloseConnection();
                }
            }
        }

    }
}
