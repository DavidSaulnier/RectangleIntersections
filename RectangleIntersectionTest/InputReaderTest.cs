using NUnit.Framework;
using RectangleIntersections.Logic;
using System.IO;

namespace RectangleIntersectionTest
{
    /// <summary>
    /// Class testing the InputFileReader class
    /// </summary>
    public class InputFileReaderTest
    {
        [Test]
        public void FileNotFoundTest()
        {
            Assert.Throws<FileNotFoundException>(() => InputReader.ReadFile("Unkown File"));
        }

        [Test]
        public void NullFileTest()
        {
            Assert.Throws<FileNotFoundException>(() => InputReader.ReadFile(null));
        }
    }
}