using NUnit.Framework;
using RectangleIntersections.Data;
using RectangleIntersections.Logic;
using System.Collections.Generic;
using System.Drawing;

namespace RectangleIntersectionTest
{
    /// <summary>
    /// Class testing the IntersectionCalculator class
    /// </summary>
    public class IntersectionCalculatorTest
    {
        /// <summary>
        /// Helper method to compare intersecting rectangles to check if they are the same
        /// </summary>
        /// <param name="interesection1">First intersecting rectangle to compare</param>
        /// <param name="interesection2">Second intersecting rectangle to compare</param>
        /// <returns></returns>
        private bool IsEqual(RectangleIntersection interesection1, RectangleIntersection interesection2)
        {
            if (interesection1.RectangleIndexes.Count != interesection2.RectangleIndexes.Count)
            {
                return false;
            }

            foreach (int index in interesection1.RectangleIndexes)
            {
                if (!interesection2.RectangleIndexes.Contains(index))
                {
                    return false;
                }
            }

            if (interesection1.Intersection.Width != interesection2.Intersection.Width
              || interesection1.Intersection.Height != interesection2.Intersection.Height
              || interesection1.Intersection.X != interesection2.Intersection.X
              || interesection1.Intersection.Y != interesection2.Intersection.Y)
            {
                return false;
            }


            return true;
        }

        [Test]
        public void CalculateIntersections0RectangleTest()
        {
            var rectangles = new List<Rectangle>();

            var expectedResult = new List<RectangleIntersection>();
            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CalculateIntersections1RectangleTest()
        {
            var rectangles = new List<Rectangle>()
            {
                new Rectangle() { X = 10, Y = 11, Width = 12, Height = 13 }
            };

            var expectedResult = new List<RectangleIntersection>();
            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CalculateIntersections4RectangleNoIntersectionTest()
        {
            var rectangles = new List<Rectangle>()
            {
                new Rectangle() { X = 10, Y = 10, Width = 10, Height = 10 },
                new Rectangle() { X = 100, Y = 100, Width = 10, Height = 10 },
                new Rectangle() { X = 1000, Y = 1000, Width = 10, Height = 10 },
                new Rectangle() { X = 10000, Y = 10000, Width = 10, Height = 10 },
            };

            var expectedResult = new List<RectangleIntersection>();
            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CalculateIntersections4RectanglesNoAreaIntersectionTest()
        {
            var rectangles = new List<Rectangle>()
            {
                new Rectangle() { X = 10, Y = 10, Width = 10, Height = 10 },
                new Rectangle() { X = 20, Y = 10, Width = 10, Height = 10 },
                new Rectangle() { X = 30, Y = 10, Width = 10, Height = 10 },
                new Rectangle() { X = 40, Y = 10, Width = 10, Height = 10 },
            };

            var expectedResult = new List<RectangleIntersection>();
            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CalculateIntersections4RectanglesTest()
        {
            var rectangles = new List<Rectangle>()
            {
                new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 },
                new Rectangle() { X = 120, Y = 200, Width = 250, Height = 150 },
                new Rectangle() { X = 140, Y = 160, Width = 250, Height = 100 },
                new Rectangle() { X = 160, Y = 140, Width = 350, Height = 190 }
            };

            var expectedResult = new List<RectangleIntersection>()
            {
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,3},
                    Intersection = new Rectangle(){ X = 140, Y = 160, Width = 210, Height = 20 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,4},
                    Intersection = new Rectangle(){ X = 160, Y = 140, Width = 190, Height = 40 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){2,3},
                    Intersection = new Rectangle(){ X = 140, Y = 200, Width = 230, Height = 60 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){2,4},
                    Intersection = new Rectangle(){ X = 160, Y = 200, Width = 210, Height = 130 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){3,4},
                    Intersection = new Rectangle(){ X = 160, Y = 160, Width = 230, Height = 100 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,3,4},
                    Intersection = new Rectangle(){ X = 160, Y = 160, Width = 190, Height = 20 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){2,3,4},
                    Intersection = new Rectangle(){ X = 160, Y = 200, Width = 210, Height = 60 }
                },
            };

            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult.Count, result.Count);

            for(int i = 0; i< expectedResult.Count;i++)
            {
                Assert.AreEqual(IsEqual(expectedResult[i], result[i]), true);
            }
        }

        [Test]
        public void CalculateIntersections4EqualRectanglesTest()
        {
            var rectangles = new List<Rectangle>()
            {
                new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
            };

            var expectedResult = new List<RectangleIntersection>()
            {
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,2},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,3},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){2,3},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){2,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,2,3},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,2,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){3,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,3,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){2,3,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
                new RectangleIntersection()
                {
                    RectangleIndexes = new List<int>(){1,2,3,4},
                    Intersection = new Rectangle() { X = 100, Y = 100, Width = 250, Height = 80 }
                },
            };

            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult.Count, result.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(IsEqual(expectedResult[i], result[i]), true);
            }
        }

        [Test]
        public void CalculateIntersections10EqualRectanglesTest()
        {
            var rectangles = new List<Rectangle>()
            {
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 },
                new Rectangle() { X = 100, Y = 101, Width = 250, Height = 80 }
            };

            var expectedCount = 1013; 

            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(result.Count, expectedCount);

            for (int i = 0; i < expectedCount; i++)
            {
                Assert.AreEqual(result[i].Intersection.X, 100);
                Assert.AreEqual(result[i].Intersection.Y, 101);
                Assert.AreEqual(result[i].Intersection.Width, 250);
                Assert.AreEqual(result[i].Intersection.Height, 80);
            }
        }
    }
}