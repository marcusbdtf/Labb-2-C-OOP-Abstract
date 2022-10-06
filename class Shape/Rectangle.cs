using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace class_Shape
{
    public class Rectangle : Shape2D
    {
        public Vector3 center;
        public Vector2 size;

        public bool IsSquare;
        public float width;
        public float radius;
        public float circumference;
        public float area;

        public Rectangle(Vector2 size)
        {
            this.size = size;
            this.circumference = size.X * 2 + size.Y * 2;
            this.area = size.X * size.Y;
        }
        public Rectangle(Vector2 center, Vector2 size) // Constructor #1
        {
            this.center = new Vector3(center.X, center.Y, 0.0f);
            this.size = size;
            this.circumference = size.X * 2 + size.Y * 2;
            this.area = size.X * size.Y;
        }
        public Rectangle(Vector2 center, float width) // Constructor #2 
        {
            this.center = new Vector3(center.X, center.Y, 0.0f);
            size.X = width;
            size.Y = width;
            this.circumference = size.X * 2 + size.Y * 2;
            this.area = size.X * size.Y;  // using this.size.X/Y to grab each of the stored floating points from (Vector2 size)

            if (size.X == size.Y)
            {
                IsSquare = true;
            }
            else
            {
                IsSquare = false;
            }
        }

        public override float Area => area; // doing the calculation directly in constructor to not get float bug

        public override Vector3 Center => center;

        public override float Circumference => circumference;

        public override string ToString() => IsSquare == false ? $"rectangle @ ({Center.X}, {center.Y}): w = {size.X}, h= {size.Y}" : $"square @ ({Center.X}, {center.Y}): w = {size.X}, h= {size.Y}";

    }
}
