using Rowerowowo.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rowerowowo.Models;

public class Vehicle : IEntity<int>
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual VehicleType? VehicleType { get; set; }

    [ForeignKey("VehicleType")]

    public int VehicleTypeId { get; set; }

}
