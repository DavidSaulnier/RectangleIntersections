using NUnit.Framework;
using RectangleIntersections.Logic;
using System;
using System.Linq;

namespace RectangleIntersectionTest
{
    /// <summary>
    /// Class testing the Parser class
    /// </summary>
    public class ParserTest
    {
        //used for test, if you change the values here, check the corresponding Unit Test.
        public const string _invalidJson = "Some random text!";
        public const string _validJsonNoRectangle = "{\"rects\": []}";
        public const string _validJsonInvalidRectangles = "{\"rects\": [{\"x\": 100, \"y\": 100, \"delta_x\": 250 }]}";
        public const string _validJsonSomeValidSomeInvalidRectangles = "{\"rects\": [{\"x\": 100, \"y\": 100, \"delta_x\": 250, \"delta_y\": 80 },{\"x\": 100, \"y\": 100, \"delta_x\": 250 }]}";
        public const string _validJsonValidRectangle = "{\"rects\": [{\"x\": 100, \"y\": 10, \"delta_x\": 250, \"delta_y\": 80 }]}";
        public const string _validJsonValidRectangles = "{\"rects\": [{\"x\": 100, \"y\": 10, \"delta_x\": 250, \"delta_y\": 80 },{\"x\": 101, \"y\": 11, \"delta_x\": 251, \"delta_y\": 81 }]}";
        public const string _validJsonRectangleWithNegativeLength = "{\"rects\": [{\"x\": 100, \"y\": 10, \"delta_x\": -250, \"delta_y\": 80 }]}";

        [Test]
        public void InvalidJsonTest()
        {
            Assert.Throws<FormatException>(() => Parser.ParseJson(_invalidJson));
        }

        [Test]
        public void ValidJsonNorectangle()
        {
            var rectangles = Parser.ParseJson(_validJsonNoRectangle);
            Assert.IsNotNull(rectangles);
            Assert.IsEmpty(rectangles.Rectangles);
        }

        [Test]
        public void ValidJson_InvalidRectangles()
        {
            Assert.Throws<FormatException>(() => Parser.ParseJson(_validJsonInvalidRectangles));
        }

        [Test]
        public void ValidJson_SomeValidSomeInvalidRectangles()
        {
            Assert.Throws<FormatException>(() => Parser.ParseJson(_validJsonSomeValidSomeInvalidRectangles));
        }

        [Test]
        public void ValidJson_ValidRectangle()
        {
            var rectangles = Parser.ParseJson(_validJsonValidRectangle);
            Assert.IsNotNull(rectangles);
            Assert.IsNotNull(rectangles.Rectangles);
            Assert.AreEqual(rectangles.Rectangles.Count, 1);

            Assert.AreEqual(rectangles.Rectangles.First().X, 100);
            Assert.AreEqual(rectangles.Rectangles.First().Y, 10);
            Assert.AreEqual(rectangles.Rectangles.First().DeltaX, 250);
            Assert.AreEqual(rectangles.Rectangles.First().DeltaY, 80);

        }

        [Test]
        public void ValidJson_ValidRectangles()
        {
            var rectangles = Parser.ParseJson(_validJsonValidRectangles);
            Assert.IsNotNull(rectangles);
            Assert.IsNotNull(rectangles.Rectangles);
            Assert.AreEqual(rectangles.Rectangles.Count, 2);

            Assert.AreEqual(rectangles.Rectangles.First().X, 100);
            Assert.AreEqual(rectangles.Rectangles.First().Y, 10);
            Assert.AreEqual(rectangles.Rectangles.First().DeltaX, 250);
            Assert.AreEqual(rectangles.Rectangles.First().DeltaY, 80);

            Assert.AreEqual(rectangles.Rectangles.Last().X, 101);
            Assert.AreEqual(rectangles.Rectangles.Last().Y, 11);
            Assert.AreEqual(rectangles.Rectangles.Last().DeltaX, 251);
            Assert.AreEqual(rectangles.Rectangles.Last().DeltaY, 81);
        }

        //valid rectangle for parsing. Will be handled during validation
        [Test]
        public void ValidJson_RectangleWithNegativeLength()
        {
            var rectangles = Parser.ParseJson(_validJsonRectangleWithNegativeLength);
            Assert.IsNotNull(rectangles);
            Assert.IsNotNull(rectangles.Rectangles);
            Assert.AreEqual(rectangles.Rectangles.Count, 1);

            Assert.AreEqual(rectangles.Rectangles.First().X, 100);
            Assert.AreEqual(rectangles.Rectangles.First().Y, 10);
            Assert.AreEqual(rectangles.Rectangles.First().DeltaX, -250);
            Assert.AreEqual(rectangles.Rectangles.First().DeltaY, 80);

        }
    }
}