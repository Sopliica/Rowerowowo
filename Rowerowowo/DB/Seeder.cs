using Rowerowowo.InMemoryDbContext;
using Rowerowowo.Models;

namespace Rowerowowo.DB;

public class Seeder
{
    public static async Task Seed(InMemoryDBContext context)
    {

        List<VehicleType> vehicleTypes = new()
        {
            new VehicleType()
            {
                Id = 1,
                TypeName = "Rower"
            },
            new VehicleType()
            {
                Id = 2,
                TypeName = "Samochod"
            }
        };
        List<Vehicle> vehicles = new()
        {
            new Vehicle()
            {
                Name = "R01",
                VehicleType = new VehicleType()
                {
                    Id = 2,
                    TypeName = "Samochod"
                }

            }
        };
        await context.AddRangeAsync(vehicleTypes);
        //await context.AddRangeAsync(vehicles);
        await context.SaveChangesAsync();

    }
}
