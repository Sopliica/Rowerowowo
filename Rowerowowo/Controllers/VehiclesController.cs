using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rowerowowo.InMemoryDbContext;
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
    public async Task<IActionResult> Create(Vehicle vehicle)
    {
        Vehicle result;
        result = await _vehicleRepository.Create(vehicle);
        return View(result);
    }
    public async Task<IActionResult> Delete(Vehicle vehicle)
    {
        await _vehicleRepository.Delete(vehicle);
        return View();
    }
    public async Task<IActionResult> UpdateVehicle(Vehicle vehicle)
    {
        var result = await _vehicleRepository.Update(vehicle);
        return View(result);
    }
}
