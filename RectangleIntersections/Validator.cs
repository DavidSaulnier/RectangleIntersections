using System;


namespace RectangleIntersections
{
    public static class Validator
    {
        public static void Validate(JsonRectangle rectangle)
        {
            if(rectangle.DeltaX <= 0 || rectangle.DeltaY <= 0)
            {
                throw new ArgumentOutOfRangeException("Rectangles should all have positive width and height");
            }
        }
    }
}
