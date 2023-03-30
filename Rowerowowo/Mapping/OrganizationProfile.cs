using AutoMapper;
using Rowerowowo.Models;
using Rowerowowo.ViewModels;

namespace Rowerowowo.Mapping;

public class OrganizationProfile : Profile
{
	public OrganizationProfile()
	{
		CreateMap<Vehicle, VehicleView>();
		CreateMap<HireingPoint, HireingPointView>();
		CreateMap<Reservation, ReservationView>();
		CreateMap<VehicleType, VehicleTypeView>();	
	}
}
