using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RectangleIntersections
{
    public static class IntersectionCalculator
    {
        public static List<RectangleIntersection> CalculateIntersections(List<Rectangle> inputRectangles)
        {
            var intersections = new List<RectangleIntersection>();
            if (!inputRectangles.Any())
            {
                return intersections;
            }

            // Find 1st degree intersections.
            for (var i = 0; i < inputRectangles.Count - 1; i++)
            {
                for (var j = i + 1; j < inputRectangles.Count; j++)
                {
                    if (inputRectangles[i].IntersectsWith(inputRectangles[j]))
                    {
                        var intersectingRectangle = Rectangle.Intersect(inputRectangles[i], inputRectangles[j]);

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
                    if (inputRectangles[i].IntersectsWith(intersectionsCopy[k].Intersection))
                    {
                        var rectanglesIndexes = intersectionsCopy[k].RectangleIndexes.Select(x => x).ToList();
                        var intersectingRectangle = Rectangle.Intersect(inputRectangles[i], intersectionsCopy[k].Intersection);

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
