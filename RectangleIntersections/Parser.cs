using Newtonsoft.Json;
using System;

namespace RectangleIntersections
{
    public static class Parser
    {
        public static JsonRectangles ParseJson(string jsonInput)
        {
            try
            {
               return JsonConvert.DeserializeObject<JsonRectangles>(jsonInput);
            }
            catch(Exception e)
            {
                throw new FormatException("The input file is not a valid Json file", e);
            }
        }
    }
}
