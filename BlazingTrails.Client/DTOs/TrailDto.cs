using BlazingTrails.Client.Models;

namespace BlazingTrails.Client.DTOs;

public class TrailDto
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string Location { get; set; } = "";
    public int TimeInMinutes { get; set; }
    public int Length { get; set; }
    
    public List<RouteInstruction> RouteInstructions { get; set; } = [];
}