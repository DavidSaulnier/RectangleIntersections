using Newtonsoft.Json;
using RectangleIntersections.Data;
using System;

namespace RectangleIntersections.Logic
{
    /// <summary>
    /// Class taking care of Parsing data
    /// </summary>
    public static class Parser
    {
        /// <summary>
        /// Method taking care of parsing Json input into InputRectangles
        /// </summary>
        /// <param name="jsonInput">The Json input file to parse into InputRectangles</param>
        /// <returns>The InputRectangles object</returns>
        public static InputRectangles ParseJson(string jsonInput)
        {
            try
            {
               return JsonConvert.DeserializeObject<InputRectangles>(jsonInput);
            }
            catch(Exception e)
            {
                throw new FormatException("The input file is not a valid Json file", e);
            }
        }
    }
}
