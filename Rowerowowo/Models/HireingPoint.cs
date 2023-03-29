using Rowerowowo.Repository;

namespace Rowerowowo.Models;

public class HireingPoint : IEntity<int>
{
    public int Id { get; set; } 
    public string? Name { get; set; }   
    public List<HireingPoint>? vehicles { get; set; }
}
