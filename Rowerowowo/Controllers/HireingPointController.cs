using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rowerowowo.Models;
using Rowerowowo.Repository;

namespace Rowerowowo.Controllers;

public class HireingPointController : Controller
{
    private readonly IRepository<HireingPoint> _hireingPointRepository;
    private readonly IMapper _mapper;
    public HireingPointController(IRepository<HireingPoint> repository, IMapper mapper)
    {
        _hireingPointRepository = repository;
        _mapper = mapper;
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
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(HireingPoint hireingPoint)
    {
        HireingPoint result;
        result = await _hireingPointRepository.Create(hireingPoint);
        return View(result);
    }
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var toRemove = await _hireingPointRepository.GetSingle(id);
        return View(toRemove);
    }
    [HttpPost]
    public async Task<IActionResult> Delete(HireingPoint hireingPoint)
    {
        await _hireingPointRepository.Delete(hireingPoint);
        return Redirect("/HireingPoint");
    }
    public async Task<IActionResult> Edit(HireingPoint hireingPoint)
    {
        var result = await _hireingPointRepository.Update(hireingPoint);
        return View(result);
    }

}
