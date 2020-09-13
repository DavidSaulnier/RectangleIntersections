using NUnit.Framework;
using RectangleIntersections.Logic;
using System.IO;

namespace RectangleIntersectionTest
{
    /// <summary>
    /// Class testing the InputFileReader class
    /// </summary>
    public class InputReaderTest
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

        [Test]
        public void ValidFileTest()
        {
            var filename = "test.txt";
            var text = "test content";
            File.WriteAllText(filename, text);

            var content = InputReader.ReadFile(filename);

            Assert.AreEqual(content, text);

            File.Delete(filename);
        }
    }
}