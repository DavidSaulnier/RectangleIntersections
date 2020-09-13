using NUnit.Framework;
using RectangleIntersections.Data;
using RectangleIntersections.Logic;
using System;
using System.Collections.Generic;

namespace RectangleIntersectionTest
{
    /// <summary>
    /// Class testing the RectangleListBuilder
    /// </summary>
    public class RectangleListBuilderTest
    {
        [Test]
        public void BuildRectanglesValid5RectanglesTest()
        {
            var inputRectangles = new InputRectangles()
            {
                Rectangles = new List<InputRectangle>()
                {
                    new InputRectangle() { X=10, Y=11, DeltaX=12, DeltaY=13 },
                    new InputRectangle() { X=20, Y=21, DeltaX=22, DeltaY=23 },
                    new InputRectangle() { X=30, Y=31, DeltaX=32, DeltaY=33 },
                    new InputRectangle() { X=40, Y=41, DeltaX=42, DeltaY=43 },
                    new InputRectangle() { X=50, Y=51, DeltaX=52, DeltaY=53 }
                }
            };
            var rectangles = RectangleListBuilder.BuildRectangles(inputRectangles);

            Assert.AreEqual(rectangles.Count,5);

            Assert.AreEqual(rectangles[0].X, inputRectangles.Rectangles[0].X);
            Assert.AreEqual(rectangles[0].Y, inputRectangles.Rectangles[0].Y);
            Assert.AreEqual(rectangles[0].Width, inputRectangles.Rectangles[0].DeltaX);
            Assert.AreEqual(rectangles[0].Height, inputRectangles.Rectangles[0].DeltaY);

            Assert.AreEqual(rectangles[1].X, inputRectangles.Rectangles[1].X);
            Assert.AreEqual(rectangles[1].Y, inputRectangles.Rectangles[1].Y);
            Assert.AreEqual(rectangles[1].Width, inputRectangles.Rectangles[1].DeltaX);
            Assert.AreEqual(rectangles[1].Height, inputRectangles.Rectangles[1].DeltaY);

            Assert.AreEqual(rectangles[2].X, inputRectangles.Rectangles[2].X);
            Assert.AreEqual(rectangles[2].Y, inputRectangles.Rectangles[2].Y);
            Assert.AreEqual(rectangles[2].Width, inputRectangles.Rectangles[2].DeltaX);
            Assert.AreEqual(rectangles[2].Height, inputRectangles.Rectangles[2].DeltaY);

            Assert.AreEqual(rectangles[3].X, inputRectangles.Rectangles[3].X);
            Assert.AreEqual(rectangles[3].Y, inputRectangles.Rectangles[3].Y);
            Assert.AreEqual(rectangles[3].Width, inputRectangles.Rectangles[3].DeltaX);
            Assert.AreEqual(rectangles[3].Height, inputRectangles.Rectangles[3].DeltaY);

        }

        [Test]
        public void BuildRectanglesValid11RectangleTest()
        {
            var inputRectangles = new InputRectangles()
            {
                Rectangles = new List<InputRectangle>()
                {
                    new InputRectangle() { X=10, Y=11, DeltaX=12, DeltaY=13 },
                    new InputRectangle() { X=20, Y=21, DeltaX=22, DeltaY=23 },
                    new InputRectangle() { X=30, Y=31, DeltaX=32, DeltaY=33 },
                    new InputRectangle() { X=40, Y=41, DeltaX=42, DeltaY=43 },
                    new InputRectangle() { X=50, Y=51, DeltaX=52, DeltaY=53 },
                    new InputRectangle() { X=60, Y=61, DeltaX=62, DeltaY=63 },
                    new InputRectangle() { X=70, Y=71, DeltaX=72, DeltaY=73 },
                    new InputRectangle() { X=80, Y=81, DeltaX=82, DeltaY=83 },
                    new InputRectangle() { X=90, Y=91, DeltaX=92, DeltaY=93 },
                    new InputRectangle() { X=100, Y=101, DeltaX=102, DeltaY=103 },
                    new InputRectangle() { X=110, Y=111, DeltaX=112, DeltaY=113 }
                }
            };
            var rectangles = RectangleListBuilder.BuildRectangles(inputRectangles);
            //we limit to 10 the number of Rectangles created
            Assert.AreEqual(rectangles.Count, 10);

            Assert.AreEqual(rectangles[0].X, inputRectangles.Rectangles[0].X);
            Assert.AreEqual(rectangles[0].Y, inputRectangles.Rectangles[0].Y);
            Assert.AreEqual(rectangles[0].Width, inputRectangles.Rectangles[0].DeltaX);
            Assert.AreEqual(rectangles[0].Height, inputRectangles.Rectangles[0].DeltaY);

            Assert.AreEqual(rectangles[1].X, inputRectangles.Rectangles[1].X);
            Assert.AreEqual(rectangles[1].Y, inputRectangles.Rectangles[1].Y);
            Assert.AreEqual(rectangles[1].Width, inputRectangles.Rectangles[1].DeltaX);
            Assert.AreEqual(rectangles[1].Height, inputRectangles.Rectangles[1].DeltaY);

            Assert.AreEqual(rectangles[2].X, inputRectangles.Rectangles[2].X);
            Assert.AreEqual(rectangles[2].Y, inputRectangles.Rectangles[2].Y);
            Assert.AreEqual(rectangles[2].Width, inputRectangles.Rectangles[2].DeltaX);
            Assert.AreEqual(rectangles[2].Height, inputRectangles.Rectangles[2].DeltaY);

            Assert.AreEqual(rectangles[3].X, inputRectangles.Rectangles[3].X);
            Assert.AreEqual(rectangles[3].Y, inputRectangles.Rectangles[3].Y);
            Assert.AreEqual(rectangles[3].Width, inputRectangles.Rectangles[3].DeltaX);
            Assert.AreEqual(rectangles[3].Height, inputRectangles.Rectangles[3].DeltaY);

            Assert.AreEqual(rectangles[4].X, inputRectangles.Rectangles[4].X);
            Assert.AreEqual(rectangles[4].Y, inputRectangles.Rectangles[4].Y);
            Assert.AreEqual(rectangles[4].Width, inputRectangles.Rectangles[4].DeltaX);
            Assert.AreEqual(rectangles[4].Height, inputRectangles.Rectangles[4].DeltaY);

            Assert.AreEqual(rectangles[5].X, inputRectangles.Rectangles[5].X);
            Assert.AreEqual(rectangles[5].Y, inputRectangles.Rectangles[5].Y);
            Assert.AreEqual(rectangles[5].Width, inputRectangles.Rectangles[5].DeltaX);
            Assert.AreEqual(rectangles[5].Height, inputRectangles.Rectangles[5].DeltaY);

            Assert.AreEqual(rectangles[6].X, inputRectangles.Rectangles[6].X);
            Assert.AreEqual(rectangles[6].Y, inputRectangles.Rectangles[6].Y);
            Assert.AreEqual(rectangles[6].Width, inputRectangles.Rectangles[6].DeltaX);
            Assert.AreEqual(rectangles[6].Height, inputRectangles.Rectangles[6].DeltaY);

            Assert.AreEqual(rectangles[7].X, inputRectangles.Rectangles[7].X);
            Assert.AreEqual(rectangles[7].Y, inputRectangles.Rectangles[7].Y);
            Assert.AreEqual(rectangles[7].Width, inputRectangles.Rectangles[7].DeltaX);
            Assert.AreEqual(rectangles[7].Height, inputRectangles.Rectangles[7].DeltaY);

            Assert.AreEqual(rectangles[8].X, inputRectangles.Rectangles[8].X);
            Assert.AreEqual(rectangles[8].Y, inputRectangles.Rectangles[8].Y);
            Assert.AreEqual(rectangles[8].Width, inputRectangles.Rectangles[8].DeltaX);
            Assert.AreEqual(rectangles[8].Height, inputRectangles.Rectangles[8].DeltaY);

            Assert.AreEqual(rectangles[9].X, inputRectangles.Rectangles[9].X);
            Assert.AreEqual(rectangles[9].Y, inputRectangles.Rectangles[9].Y);
            Assert.AreEqual(rectangles[9].Width, inputRectangles.Rectangles[9].DeltaX);
            Assert.AreEqual(rectangles[9].Height, inputRectangles.Rectangles[9].DeltaY);

        }

        [Test]
        public void BuildRectanglesValid0RectanglesTest()
        {
            var inputRectangles = new InputRectangles()
            {
                Rectangles = new List<InputRectangle>()
                {
                }
            };
            var rectangles = RectangleListBuilder.BuildRectangles(inputRectangles);

            Assert.AreEqual(rectangles.Count, 0);
        }

        [Test]
        public void BuildRectanglesInvalid1RectanglesNegativeWidthTest()
        {
            var inputRectangles = new InputRectangles()
            {
                Rectangles = new List<InputRectangle>()
                {
                    new InputRectangle() { X=10, Y=11, DeltaX=-12, DeltaY=13 }
                }
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleListBuilder.BuildRectangles(inputRectangles));
        }

        [Test]
        public void BuildRectanglesInvalid1RectanglesNegativeHeightTest()
        {
            var inputRectangles = new InputRectangles()
            {
                Rectangles = new List<InputRectangle>()
                {
                    new InputRectangle() { X=10, Y=11, DeltaX=12, DeltaY=-13 }
                }
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleListBuilder.BuildRectangles(inputRectangles));
        }

        [Test]
        public void BuildRectanglesInvalid1RectanglesNegativeWidthAndHeight()
        {
            var inputRectangles = new InputRectangles()
            {
                Rectangles = new List<InputRectangle>()
                {
                    new InputRectangle() { X=10, Y=11, DeltaX=-12, DeltaY=-13 }
                }
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleListBuilder.BuildRectangles(inputRectangles));
        }
    }
}