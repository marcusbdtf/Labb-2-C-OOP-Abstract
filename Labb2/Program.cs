// See https://aka.ms/new-console-template for more information
using class_Shape;
using System.Formats.Asn1;
using System.Numerics;
using System.Runtime.Intrinsics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> { };

        for (int i = 0; i < 19; i++)
        {
            shapes.Add(Shape.GenerateShape());
        }

        float total_area = 0.0f;

        foreach (var shape in shapes)
        {

            if (shape.Area == float.NaN || shape.Area == 0.0f) // dont know how to stop NaN from appearing.
            {
                float temp = 0.0f;
                total_area += temp;
                Console.WriteLine($"New Shape Created: {shape}");
                Console.WriteLine($"Area: {temp}"); // dont know how to stop NaN from appearing.
                Console.WriteLine();
            }
            else
            {
                total_area += shape.Area;
                Console.WriteLine($"New Shape Created: {shape}");
                Console.WriteLine($"Area: {shape.Area}");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"The avarage area of all shapes added together is: {total_area / 20.0f}");
        // Produces desired outcome if triangle area does not become NaN : Tried to fix can't find
    }
}