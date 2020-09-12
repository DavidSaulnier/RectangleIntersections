using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RectangleIntersections
{
    public static class RectangleListBuilder
    {
        public static List<Rectangle> BuildRectangles(JsonRectangles jsonRectangles, int limit = 10)
        {
            var rectangleList = new List<Rectangle>();

            foreach(var rectangle in jsonRectangles.Rectangles.Take(limit))
            {
                Validator.Validate(rectangle);
                rectangleList.Add(new Rectangle(
                                                new Point(rectangle.X, rectangle.Y),
                                                new Size(rectangle.DeltaX, rectangle.DeltaY))
                                                );
            }

            return rectangleList;
        }
    }
}
