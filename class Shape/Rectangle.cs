using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace class_Shape
{
    public class Rectangle : Shape2D
    {
        public Vector3 center;
        public Vector2 size;

        public bool IsSquare { get { return size.X == size.Y; } }
        public float width { get; }
        public float radius { get; }
        public float circumference { get { return 2 * (size.X + size.Y); } }
        public float area { get { return size.X * size.Y; } }


        public Rectangle(Vector2 size)
        {
            this.size = size;
        }
        public Rectangle(Vector2 center, Vector2 size) // Constructor #1
        {
            this.center = new Vector3(center.X, center.Y, 0.0f);
            this.size = size;

        }
        public Rectangle(Vector2 center, float width) // Constructor #2 
        {
            this.center = new Vector3(center.X, center.Y, 0.0f);
            size.X = width;
            size.Y = width;
        }

        public override float Area => area; // doing the calculation directly in constructor to not get float bug

        public override Vector3 Center => center;

        public override float Circumference => circumference;

        public override string ToString() => IsSquare == false ? $"rectangle @ ({Center.X}, {center.Y}): w = {size.X}, h= {size.Y}" : $"square @ ({Center.X}, {center.Y}): w = {size.X}, h= {size.Y}";

    }
}
