using Microsoft.AspNetCore.Mvc;
using Rowerowowo.Models;
using Rowerowowo.Repository;

namespace Rowerowowo.Controllers;

public class VehiclesController : Controller
{
    private readonly IRepository<Vehicle> _vehicleRepository;

    public VehiclesController(IRepository<Vehicle> vehicleRepository)
    {

        _vehicleRepository = vehicleRepository;
    }
    
    public async Task<IActionResult> Index()
    {
        List<Vehicle> resoult = new List<Vehicle>();
        resoult = (await _vehicleRepository.GetAll()).ToList();
        return View(resoult);

    }
    public async Task<IActionResult> GetSingleVehicleById(int id)
    {
        Vehicle result;
        result = await (_vehicleRepository.GetSingle(id));
        return View(result);    
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
     
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Vehicle vehicle)
    {
        Vehicle result;
        result = await _vehicleRepository.Create(vehicle);
        return View(result);
    }
    public async Task<IActionResult> Delete(Vehicle vehicle)
    {
        await _vehicleRepository.Delete(vehicle); // tu await nie działa
        return Redirect("/Vehicles");
    }
    public async Task<IActionResult> Edit(Vehicle vehicle)
    {
        var result = await _vehicleRepository.Update(vehicle);
        return View(result);
    }
}
