using RectangleIntersections.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RectangleIntersections.Logic
{
    /// <summary>
    /// Class taking care of calculating the intersecting rectangles
    /// </summary>
    public static class IntersectionCalculator
    {
        /// <summary>
        /// Method taking care of calculating the intersecting rectangles
        /// </summary>
        /// <param name="rectangles">List of System.Drawing.Rectangle object representing the rectangles we have to process</param>
        /// <returns>A list of RectangleIntersection objects representing each an intersection between two rectangles</returns>
        public static List<RectangleIntersection> CalculateIntersections(List<Rectangle> rectangles)
        {
            var intersections = new List<RectangleIntersection>();
            if (!rectangles.Any())
            {
                return intersections;
            }

            // Find 1st degree intersections.
            for (var i = 0; i < rectangles.Count - 1; i++)
            {
                for (var j = i + 1; j < rectangles.Count; j++)
                {
                    if (rectangles[i].IntersectsWith(rectangles[j]))
                    {
                        var intersectingRectangle = Rectangle.Intersect(rectangles[i], rectangles[j]);

                        if (intersectingRectangle.Width != 0 && intersectingRectangle.Height != 0)
                        {
                            intersections.Add(new RectangleIntersection()
                            {
                                RectangleIndexes = new List<int>() { i + 1, j + 1 },
                                Intersection = intersectingRectangle
                            });
                        }
                    }
                }


                // find intersections with already intersected rectangles
                var intersectionsCopy = intersections.Select(x => x).ToList();
                for (var k = 0; k < intersectionsCopy.Count; k++)
                {
                    if (rectangles[i].IntersectsWith(intersectionsCopy[k].Intersection))
                    {
                        var rectanglesIndexes = intersectionsCopy[k].RectangleIndexes.Select(x => x).ToList();
                        var intersectingRectangle = Rectangle.Intersect(rectangles[i], intersectionsCopy[k].Intersection);

                        if (!rectanglesIndexes.Contains(i + 1) && intersectingRectangle.Width != 0 && intersectingRectangle.Height != 0)
                        {
                            rectanglesIndexes.Add(i + 1);
                            intersections.Add(new RectangleIntersection()
                            {
                                RectangleIndexes = rectanglesIndexes,
                                Intersection = intersectingRectangle
                            });
                        }
                    }
                }
            }

            return intersections;
        }

      
    }
}
