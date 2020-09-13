using NUnit.Framework;
using RectangleIntersections.Data;
using RectangleIntersections.Logic;
using System;

namespace RectangleIntersectionTest
{
    /// <summary>
    /// Class testing the RectangleValidator class
    /// </summary>
    public class RectangleValidatorTest
    {
        
        [Test]
        public void RectangleWithNegativeWidth()
        {
            InputRectangle rectangle = new InputRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = -100,
                DeltaY = 100
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleValidator.Validate(rectangle));
        }

        [Test]
        public void RectangleWithNegativeHeight()
        {
            InputRectangle rectangle = new InputRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = 100,
                DeltaY = -100
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleValidator.Validate(rectangle));
        }

        [Test]
        public void RectangleWithNegativeWidthAndNegativeHeight()
        {
            InputRectangle rectangle = new InputRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = -100,
                DeltaY = -100
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleValidator.Validate(rectangle));
        }

        [Test]
        public void Valid()
        {
            InputRectangle rectangle = new InputRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = 100,
                DeltaY = 100
            };
            Assert.DoesNotThrow(() => RectangleValidator.Validate(rectangle));
        }
    }
}