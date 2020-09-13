using Newtonsoft.Json;
using System.Collections.Generic;

namespace RectangleIntersections.Data
{
    /// <summary>
    /// Class Containing the List of rectangles given as input
    /// </summary>
    public class InputRectangles
    {
        [JsonProperty("rects", Required = Required.Always)]
        public List<InputRectangle> Rectangles { get; set; }
    }

}
