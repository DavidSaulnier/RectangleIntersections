using NUnit.Framework;
using RectangleIntersections;
using System.IO;

namespace RectangleIntersectionTest
{
    public class InputFileReaderTest
    {
        [Test]
        public void FileNotFoundTest()
        {
            Assert.Throws<FileNotFoundException>(() => InputFileReader.ReadFile("Unkown File"));
        }

        [Test]
        public void NullFileTest()
        {
            Assert.Throws<FileNotFoundException>(() => InputFileReader.ReadFile(null));
        }
    }
}