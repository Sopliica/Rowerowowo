using Rowerowowo.Models;

namespace Rowerowowo.ViewModels;

public class HireingPointView
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<HireingPoint>? vehicles { get; set; }
}
