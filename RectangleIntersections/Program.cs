using RectangleIntersections.Logic;
using System;
using System.Linq;

namespace RectangleIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!args.Any())
                {
                    throw new ArgumentException("Error: no file provided");
                }

                var content = InputReader.ReadFile(args[0]);

                var jsonRectangles = Parser.ParseJson(content);

                var rectangles = RectangleListBuilder.BuildRectangles(jsonRectangles);

                var intersections = IntersectionCalculator.CalculateIntersections(rectangles);

                ResultWriter.Display(rectangles, intersections);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine(e.InnerException.Message);
                }
            }
        }
    }
}
