using Newtonsoft.Json;
using System.Collections.Generic;

namespace RectangleIntersections
{
    public class JsonRectangles
    {
        [JsonProperty("rects", Required = Required.Always)]
        public List<JsonRectangle> Rectangles { get; set; }
    }

    public class JsonRectangle
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
