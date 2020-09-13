using RectangleIntersections.Data;
using System;

namespace RectangleIntersections.Logic
{
    /// <summary>
    /// Class taking care of validating rectangles according to specifications
    /// </summary>
    public static class RectangleValidator
    {
        /// <summary>
        /// Method validating rectangles according to specifications:
        /// DeltaX and DeltaY are positive integers
        /// </summary>
        /// <param name="rectangle">A valid rectangle</param>
        public static void Validate(InputRectangle rectangle)
        {
            if(rectangle.DeltaX <= 0 || rectangle.DeltaY <= 0)
            {
                throw new ArgumentOutOfRangeException("Rectangles should all have positive width and height");
            }
        }
    }
}
