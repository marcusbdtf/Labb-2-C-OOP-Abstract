using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_Shape
{
    public class Circle : Shape2D
    {
        public Vector2 center2;
        public Vector3 center;
        public float radius;
        public float circumference;
        public float area;

        public Circle(Vector2 center)
        {
            this.center2 = center;
            this.center = new Vector3(center.X, center.Y, 0.0f);
            this.circumference = (radius * 2) * PI;
            this.area = (float)Math.Pow(radius, 2.0f) * PI;
        }
        public Circle(Vector2 center, float radius)
        {
            this.center2 = center;
            this.center = new Vector3(center.X, center.Y, 0.0f);
            this.radius = radius;
            this.circumference = (radius * 2) * PI;
            this.area = (float)Math.Pow(radius, 2.0f) * PI; 
        }
        override public float Area => area;

        public override float Circumference => circumference;

        public override Vector3 Center => center;

        public override string ToString() => $"circle @ ({this.center.X} ,{this.center.Y}) : r = {this.radius}";

        }
}
