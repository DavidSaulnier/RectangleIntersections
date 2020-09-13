using System.IO;

namespace RectangleIntersections.Logic
{
    /// <summary>
    /// Class taking care of reading the input
    /// </summary>
    public static class InputReader
    {
        /// <summary>
        /// Method taking care of reading the file given as input
        /// </summary>
        /// <param name="fileName">The filename of the input file</param>
        /// <returns>A string containing the content of the input file</returns>
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
