using System.Collections.Generic;
using System.Drawing;

namespace RectangleIntersections.Data
{
    /// <summary>
    /// Class representing the intersection between rectangles
    /// RectangleIndexes represent the index of the intersecting rectangles
    /// Intersection represents the resulting intersecting rectangle
    /// </summary>
    public class RectangleIntersection
    {
        public List<int> RectangleIndexes { get; set; }

        public Rectangle Intersection { get; set; }

    }
}
