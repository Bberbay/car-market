namespace Entities.Dtos;

public class CarPropertyAddDto
{
    public int Id { get; set; }    
    public string Color { get; set; }
    public short FuelType { get; set; }
    public short Gear { get; set; }
    public short EnginePower { get; set; }
    public short EngineCapacity { get; set; }
    public short HeadlampFog { get; set; }
    public short FoldingMirros { get; set; }
    public short ParkingSensor { get; set; }
    public short CentralLock { get; set; }
    public short SunRoof { get; set; }
}