using RectangleIntersections.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RectangleIntersections.Logic
{
    public static class ResultWriter
    {
        /// <summary>
        /// Class taking care of displaying the results of the program.
        /// </summary>
        /// <param name="rectangles">The list of Rectangles used as input</param>
        /// <param name="intersectingRectangles">The list of intersecting rectangles</param>
        public static void Display(List<Rectangle> rectangles, List<RectangleIntersection> intersectingRectangles)
        {
            Console.WriteLine("Input:");
            var counter = 1;

            foreach(var rectangle in rectangles)
            {
                Console.WriteLine($"{counter++}: Rectangle at ({rectangle.X},{rectangle.Y}), delta_x={rectangle.Width}, delta_y={rectangle.Height}.");
            }

            Console.WriteLine("");
            Console.WriteLine("Intersections:");
            counter = 1;

            foreach (var intersectingRectangle in intersectingRectangles)
            {
                string indexes = "";
                intersectingRectangle.RectangleIndexes = intersectingRectangle.RectangleIndexes.OrderBy(x => x).ToList();
                for (int i = 0; i<intersectingRectangle.RectangleIndexes.Count; i++)
                {
                    if (i == intersectingRectangle.RectangleIndexes.Count - 1)
                    {
                        indexes += " and";
                    }
                    indexes += $" {intersectingRectangle.RectangleIndexes[i]}";

                    if (i < intersectingRectangle.RectangleIndexes.Count - 2)
                    {
                        indexes += ",";
                    }
                }

                Console.WriteLine($"{counter++}: Between rectangle{indexes} at ({intersectingRectangle.Intersection.X},{intersectingRectangle.Intersection.Y}), delta_x={intersectingRectangle.Intersection.Width}, delta_y={intersectingRectangle.Intersection.Height}.");
            }
        }
    }
}
