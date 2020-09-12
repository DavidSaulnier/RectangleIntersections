using NUnit.Framework;
using RectangleIntersections;
using System.Collections.Generic;
using System.Drawing;

namespace RectangleIntersectionTest
{
    public class IntersectionCalculatorTest
    {

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
        public void CalculateIntersections_0_Rectangle()
        {
            var rectangles = new List<Rectangle>();

            var expectedResult = new List<RectangleIntersection>();
            var result = IntersectionCalculator.CalculateIntersections(rectangles);

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void CalculateIntersections_1_Rectangle()
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
        public void CalculateIntersections_4_Rectangle_No_Intersection()
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
        public void CalculateIntersections_4_Rectangles()
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
        public void CalculateIntersections_4_Equal_Rectangles()
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
                    RectangleIndexes = new List<int>(){1,2,3},
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
    }
}