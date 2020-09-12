using NUnit.Framework;
using RectangleIntersections;
using System;

namespace RectangleIntersectionTest
{
    public class ValidatorTest
    {
        
        [Test]
        public void RectangleWithNegativeWidth()
        {
            JsonRectangle rectangle = new JsonRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = -100,
                DeltaY = 100
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => Validator.Validate(rectangle));
        }

        [Test]
        public void RectangleWithNegativeHeight()
        {
            JsonRectangle rectangle = new JsonRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = 100,
                DeltaY = -100
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => Validator.Validate(rectangle));
        }

        [Test]
        public void RectangleWithNegativeWidthAndNegativeHeight()
        {
            JsonRectangle rectangle = new JsonRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = -100,
                DeltaY = -100
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => Validator.Validate(rectangle));
        }

        [Test]
        public void Valid()
        {
            JsonRectangle rectangle = new JsonRectangle()
            {
                X = 10,
                Y = 20,
                DeltaX = 100,
                DeltaY = 100
            };
            Assert.DoesNotThrow(() => Validator.Validate(rectangle));
        }
    }
}