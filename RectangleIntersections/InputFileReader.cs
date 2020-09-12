using System.IO;

namespace RectangleIntersections
{
    public static class InputFileReader
    {
        public static string ReadFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"The file {fileName} is not found");
            }

            using (StreamReader r = new StreamReader(fileName))
            {
                return r.ReadToEnd();
            }
        }
    }
}
