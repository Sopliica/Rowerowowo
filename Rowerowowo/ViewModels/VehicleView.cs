using Rowerowowo.Models;

namespace Rowerowowo.ViewModels;

public class VehicleView
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public virtual VehicleType? VehicleType { get; set; }
}
