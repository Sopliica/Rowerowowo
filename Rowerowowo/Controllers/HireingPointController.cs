using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rowerowowo.InMemoryDbContext;
using Rowerowowo.Models;
using Rowerowowo.Repository;

namespace Rowerowowo.Controllers;

public class HireingPointController : Controller
{
    private readonly IRepository<HireingPoint> _hireingPointRepository;
    public HireingPointController(IRepository<HireingPoint> repository)
    {
        _hireingPointRepository = repository;   
    }

    public async Task<IActionResult> Index()
    {
        List<HireingPoint> resoult = new List<HireingPoint>();
        resoult = (await _hireingPointRepository.GetAll()).ToList();
        return View(resoult);

    }
    public async Task<IActionResult> GetSingleHireingPointById(int id)
    {
        HireingPoint result;
        result = await (_hireingPointRepository.GetSingle(id));
        return View(result);
    }
    public async Task<IActionResult> Create(HireingPoint hireingPoint)
    {
        HireingPoint result;
        result = await _hireingPointRepository.Create(hireingPoint);
        return View(result);
    }
    public async Task<IActionResult> Delete(HireingPoint hireingPoint)
    {
        _hireingPointRepository.Delete(hireingPoint);
        return View();
    }
    public async Task<IActionResult> Update(HireingPoint hireingPoint)
    {
        var result = await _hireingPointRepository.Update(hireingPoint);
        return View(result);
    }

}
