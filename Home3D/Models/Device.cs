using System.Text.Json.Serialization;

namespace Home3D.Models;

public class Device
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}
