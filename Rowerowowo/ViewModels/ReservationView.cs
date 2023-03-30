using Rowerowowo.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rowerowowo.ViewModels;

public class ReservationView
{
    public int Id { get; set; }
    public DateTime ReservationStartDate { get; set; }

    public DateTime ReservationEndDate { get; set; }

    public virtual Vehicle? Vehicle { get; set; }
}
