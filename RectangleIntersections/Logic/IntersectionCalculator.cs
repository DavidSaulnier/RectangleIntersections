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

            // process rectangles in order, the indexes represent the order in which they appear in the file
            for (var i = 0; i < rectangles.Count - 1; i++)
            {
                var indexCurrentRectangle = i + 1;
                // find 1st degree intersections.
                for (var j = i + 1; j < rectangles.Count; j++)
                {
                    var indexIntersectingRectangle = j + 1;
                    if (rectangles[i].IntersectsWith(rectangles[j]))
                    {
                        var intersectingRectangle = Rectangle.Intersect(rectangles[i], rectangles[j]);

                        if (intersectingRectangle.Width != 0 && intersectingRectangle.Height != 0)
                        {
                            intersections.Add(new RectangleIntersection()
                            {
                                RectangleIndexes = new List<int>() { indexCurrentRectangle, indexIntersectingRectangle },
                                Intersection = intersectingRectangle
                            });
                        }
                    }
                }

                // find intersections with already intersected rectangles
                for (var k = 0; k < intersections.Count; k++)
                {
                    // if the intersection already includes this rectangle, skip it 
                    if (intersections[k].RectangleIndexes.Contains(indexCurrentRectangle))
                    {
                        continue;
                    }
                    // we process rectangles in order so we don't need to check intersections with rectangles at a lower "index"
                    if (intersections[k].RectangleIndexes.Max() < indexCurrentRectangle)
                    {
                        continue;
                    }
                    if (rectangles[i].IntersectsWith(intersections[k].Intersection))
                    {
                        var rectanglesIndexes = intersections[k].RectangleIndexes.Select(x => x).ToList();
                        rectanglesIndexes.Add(indexCurrentRectangle);
                        var intersectingRectangle = Rectangle.Intersect(rectangles[i], intersections[k].Intersection);

                        // only insert intersecting rectangles with an area
                        if (intersectingRectangle.Width != 0 && intersectingRectangle.Height != 0)
                        {
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
