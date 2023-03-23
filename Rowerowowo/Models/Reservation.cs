using System.ComponentModel.DataAnnotations.Schema;

namespace Rowerowowo.Models;

public class Reservation
{
    public int Id { get; set; }

    public DateTime ReservationStartDate { get; set; }

    public DateTime ReservationEndDate { get; set; }

    public virtual Vehicle Vehicle { get; set; }

    [ForeignKey("Vehicle")]
    public int VehicleId { get; set; }
}


