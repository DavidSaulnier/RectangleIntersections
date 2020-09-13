using Newtonsoft.Json;

namespace RectangleIntersections.Data
{

    /// <summary>
    /// Class representing a rectangle given as input
    /// </summary>
    public class InputRectangle
    {
        [JsonProperty("x", Required = Required.Always)]
        public int X { get; set; }

        [JsonProperty("y", Required = Required.Always)]
        public int Y { get; set; }

        [JsonProperty("delta_x", Required = Required.Always)]
        public int DeltaX{ get; set; }

        [JsonProperty("delta_y", Required = Required.Always)]
        public int DeltaY { get; set; }
    }
}
