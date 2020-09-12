using NUnit.Framework;
using RectangleIntersections;
using System;
using System.Collections.Generic;

namespace RectangleIntersectionTest
{
    public class RectangleListBuilderTest
    {
        [Test]
        public void BuildRectangles_Valid_5_Rectangles()
        {
            var jsonRectangles = new JsonRectangles()
            {
                Rectangles = new List<JsonRectangle>()
                {
                    new JsonRectangle() { X=10, Y=11, DeltaX=12, DeltaY=13 },
                    new JsonRectangle() { X=20, Y=21, DeltaX=22, DeltaY=23 },
                    new JsonRectangle() { X=30, Y=31, DeltaX=32, DeltaY=33 },
                    new JsonRectangle() { X=40, Y=41, DeltaX=42, DeltaY=43 },
                    new JsonRectangle() { X=50, Y=51, DeltaX=52, DeltaY=53 }
                }
            };
            var rectangles = RectangleListBuilder.BuildRectangles(jsonRectangles);

            Assert.AreEqual(rectangles.Count,5);

            Assert.AreEqual(rectangles[0].X, jsonRectangles.Rectangles[0].X);
            Assert.AreEqual(rectangles[0].Y, jsonRectangles.Rectangles[0].Y);
            Assert.AreEqual(rectangles[0].Width, jsonRectangles.Rectangles[0].DeltaX);
            Assert.AreEqual(rectangles[0].Height, jsonRectangles.Rectangles[0].DeltaY);

            Assert.AreEqual(rectangles[1].X, jsonRectangles.Rectangles[1].X);
            Assert.AreEqual(rectangles[1].Y, jsonRectangles.Rectangles[1].Y);
            Assert.AreEqual(rectangles[1].Width, jsonRectangles.Rectangles[1].DeltaX);
            Assert.AreEqual(rectangles[1].Height, jsonRectangles.Rectangles[1].DeltaY);

            Assert.AreEqual(rectangles[2].X, jsonRectangles.Rectangles[2].X);
            Assert.AreEqual(rectangles[2].Y, jsonRectangles.Rectangles[2].Y);
            Assert.AreEqual(rectangles[2].Width, jsonRectangles.Rectangles[2].DeltaX);
            Assert.AreEqual(rectangles[2].Height, jsonRectangles.Rectangles[2].DeltaY);

            Assert.AreEqual(rectangles[3].X, jsonRectangles.Rectangles[3].X);
            Assert.AreEqual(rectangles[3].Y, jsonRectangles.Rectangles[3].Y);
            Assert.AreEqual(rectangles[3].Width, jsonRectangles.Rectangles[3].DeltaX);
            Assert.AreEqual(rectangles[3].Height, jsonRectangles.Rectangles[3].DeltaY);

        }

        [Test]
        public void BuildRectangles_Valid_11_Rectangle()
        {
            var jsonRectangles = new JsonRectangles()
            {
                Rectangles = new List<JsonRectangle>()
                {
                    new JsonRectangle() { X=10, Y=11, DeltaX=12, DeltaY=13 },
                    new JsonRectangle() { X=20, Y=21, DeltaX=22, DeltaY=23 },
                    new JsonRectangle() { X=30, Y=31, DeltaX=32, DeltaY=33 },
                    new JsonRectangle() { X=40, Y=41, DeltaX=42, DeltaY=43 },
                    new JsonRectangle() { X=50, Y=51, DeltaX=52, DeltaY=53 },
                    new JsonRectangle() { X=60, Y=61, DeltaX=62, DeltaY=63 },
                    new JsonRectangle() { X=70, Y=71, DeltaX=72, DeltaY=73 },
                    new JsonRectangle() { X=80, Y=81, DeltaX=82, DeltaY=83 },
                    new JsonRectangle() { X=90, Y=91, DeltaX=92, DeltaY=93 },
                    new JsonRectangle() { X=100, Y=101, DeltaX=102, DeltaY=103 },
                    new JsonRectangle() { X=110, Y=111, DeltaX=112, DeltaY=113 }
                }
            };
            var rectangles = RectangleListBuilder.BuildRectangles(jsonRectangles);
            //we limit to 10 the number of Rectangles created
            Assert.AreEqual(rectangles.Count, 10);

            Assert.AreEqual(rectangles[0].X, jsonRectangles.Rectangles[0].X);
            Assert.AreEqual(rectangles[0].Y, jsonRectangles.Rectangles[0].Y);
            Assert.AreEqual(rectangles[0].Width, jsonRectangles.Rectangles[0].DeltaX);
            Assert.AreEqual(rectangles[0].Height, jsonRectangles.Rectangles[0].DeltaY);

            Assert.AreEqual(rectangles[1].X, jsonRectangles.Rectangles[1].X);
            Assert.AreEqual(rectangles[1].Y, jsonRectangles.Rectangles[1].Y);
            Assert.AreEqual(rectangles[1].Width, jsonRectangles.Rectangles[1].DeltaX);
            Assert.AreEqual(rectangles[1].Height, jsonRectangles.Rectangles[1].DeltaY);

            Assert.AreEqual(rectangles[2].X, jsonRectangles.Rectangles[2].X);
            Assert.AreEqual(rectangles[2].Y, jsonRectangles.Rectangles[2].Y);
            Assert.AreEqual(rectangles[2].Width, jsonRectangles.Rectangles[2].DeltaX);
            Assert.AreEqual(rectangles[2].Height, jsonRectangles.Rectangles[2].DeltaY);

            Assert.AreEqual(rectangles[3].X, jsonRectangles.Rectangles[3].X);
            Assert.AreEqual(rectangles[3].Y, jsonRectangles.Rectangles[3].Y);
            Assert.AreEqual(rectangles[3].Width, jsonRectangles.Rectangles[3].DeltaX);
            Assert.AreEqual(rectangles[3].Height, jsonRectangles.Rectangles[3].DeltaY);

            Assert.AreEqual(rectangles[4].X, jsonRectangles.Rectangles[4].X);
            Assert.AreEqual(rectangles[4].Y, jsonRectangles.Rectangles[4].Y);
            Assert.AreEqual(rectangles[4].Width, jsonRectangles.Rectangles[4].DeltaX);
            Assert.AreEqual(rectangles[4].Height, jsonRectangles.Rectangles[4].DeltaY);

            Assert.AreEqual(rectangles[5].X, jsonRectangles.Rectangles[5].X);
            Assert.AreEqual(rectangles[5].Y, jsonRectangles.Rectangles[5].Y);
            Assert.AreEqual(rectangles[5].Width, jsonRectangles.Rectangles[5].DeltaX);
            Assert.AreEqual(rectangles[5].Height, jsonRectangles.Rectangles[5].DeltaY);

            Assert.AreEqual(rectangles[6].X, jsonRectangles.Rectangles[6].X);
            Assert.AreEqual(rectangles[6].Y, jsonRectangles.Rectangles[6].Y);
            Assert.AreEqual(rectangles[6].Width, jsonRectangles.Rectangles[6].DeltaX);
            Assert.AreEqual(rectangles[6].Height, jsonRectangles.Rectangles[6].DeltaY);

            Assert.AreEqual(rectangles[7].X, jsonRectangles.Rectangles[7].X);
            Assert.AreEqual(rectangles[7].Y, jsonRectangles.Rectangles[7].Y);
            Assert.AreEqual(rectangles[7].Width, jsonRectangles.Rectangles[7].DeltaX);
            Assert.AreEqual(rectangles[7].Height, jsonRectangles.Rectangles[7].DeltaY);

            Assert.AreEqual(rectangles[8].X, jsonRectangles.Rectangles[8].X);
            Assert.AreEqual(rectangles[8].Y, jsonRectangles.Rectangles[8].Y);
            Assert.AreEqual(rectangles[8].Width, jsonRectangles.Rectangles[8].DeltaX);
            Assert.AreEqual(rectangles[8].Height, jsonRectangles.Rectangles[8].DeltaY);

            Assert.AreEqual(rectangles[9].X, jsonRectangles.Rectangles[9].X);
            Assert.AreEqual(rectangles[9].Y, jsonRectangles.Rectangles[9].Y);
            Assert.AreEqual(rectangles[9].Width, jsonRectangles.Rectangles[9].DeltaX);
            Assert.AreEqual(rectangles[9].Height, jsonRectangles.Rectangles[9].DeltaY);

        }

        [Test]
        public void BuildRectangles_Valid_0_Rectangles()
        {
            var jsonRectangles = new JsonRectangles()
            {
                Rectangles = new List<JsonRectangle>()
                {
                }
            };
            var rectangles = RectangleListBuilder.BuildRectangles(jsonRectangles);

            Assert.AreEqual(rectangles.Count, 0);
        }

        [Test]
        public void BuildRectangles_Invalid_1_Rectangles_Negative_Width()
        {
            var jsonRectangles = new JsonRectangles()
            {
                Rectangles = new List<JsonRectangle>()
                {
                    new JsonRectangle() { X=10, Y=11, DeltaX=-12, DeltaY=13 }
                }
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleListBuilder.BuildRectangles(jsonRectangles));
        }

        [Test]
        public void BuildRectangles_Invalid_1_Rectangles_Negative_Height()
        {
            var jsonRectangles = new JsonRectangles()
            {
                Rectangles = new List<JsonRectangle>()
                {
                    new JsonRectangle() { X=10, Y=11, DeltaX=12, DeltaY=-13 }
                }
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleListBuilder.BuildRectangles(jsonRectangles));
        }

        [Test]
        public void BuildRectangles_Invalid_1_Rectangles_Negative_Width_And_Height()
        {
            var jsonRectangles = new JsonRectangles()
            {
                Rectangles = new List<JsonRectangle>()
                {
                    new JsonRectangle() { X=10, Y=11, DeltaX=-12, DeltaY=-13 }
                }
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => RectangleListBuilder.BuildRectangles(jsonRectangles));
        }
    }
}