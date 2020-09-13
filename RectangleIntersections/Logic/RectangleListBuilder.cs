using RectangleIntersections.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RectangleIntersections.Logic
{
    /// <summary>
    ///  Class taking care of building the list of System.Drawing.Rectangles to use for our calculation
    ///  Specifications are:
    ///  - limit to 10 rectangles
    ///  - rectangles are definied with a positive integer for width and height. (the RectangleValidator class will validate that)
    /// </summary>
    public static class RectangleListBuilder
    {
        /// <summary>
        /// Method taking care of building the list of System.Drawing.Rectangles to use for our calcualtion
        /// </summary>
        /// <param name="inputRectangles">the InputRectangles given as input</param>
        /// <param name="limit">The number of rectangle we want to keep, defaults to 10</param>
        /// <returns>A list of valid System.Drawing.Ractangle</returns>
        public static List<Rectangle> BuildRectangles(InputRectangles inputRectangles, int limit = 10)
        {
            var rectangleList = new List<Rectangle>();

            foreach(var rectangle in inputRectangles.Rectangles.Take(limit))
            {
                RectangleValidator.Validate(rectangle);
                rectangleList.Add(new Rectangle(
                                                new Point(rectangle.X, rectangle.Y),
                                                new Size(rectangle.DeltaX, rectangle.DeltaY))
                                                );
            }

            return rectangleList;
        }
    }
}
