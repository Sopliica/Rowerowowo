using FluentValidation;
using Rowerowowo.Models;

namespace Rowerowowo.Validators;
public class ReservationValidator :AbstractValidator<Reservation>
{
	public ReservationValidator()
	{
		RuleFor(x => x.ReservationEndDate).GreaterThan(x => x.ReservationStartDate);
	}
}
