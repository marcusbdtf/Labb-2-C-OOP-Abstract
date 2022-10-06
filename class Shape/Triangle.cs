using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace class_Shape
{
    public class Triangle : Shape2D
    {
        public Vector2 p1;
        public Vector2 p2;
        public Vector2 p3;
        public Vector3 center;

        public float aB; // variables for distance formula
        public float aC; 
        public float bC; 
        public float semiP;
        public float radius;
        public float circumference;
        public float area;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;


            center.X = (p1.X + p2.X + p3.X) / 3.0f; // Extracting coordinate for center
            center.Y = (p1.Y + p2.Y + p3.Y) / 3.0f;

            aB = (float)Math.Pow((p1.X - p2.X), 2) + (float)Math.Pow((p1.Y - p2.Y), 2); // Using distance method
            aC = (float)Math.Pow((p1.X - p3.X), 2) + (float)Math.Pow((p1.Y - p3.Y), 2); // storing the length of sides
            bC = (float)Math.Pow((p2.X - p3.X), 2) + (float)Math.Pow((p2.Y - p3.Y), 2);

            semiP = (aB + aC + bC) / 2;
            this.circumference = aB + aC + bC;

            float temp = (float)Math.Sqrt(semiP * (semiP - aB) * (semiP - aC) * (semiP - bC));
            if (temp == float.NaN || temp == 0) // dont know how to stop NaN from appearing.
            {
                this.area = 0.0f;
            }
            else
            {
                this.area = temp;
            }


        }


        public override float Area => area; // help from: https://dotnettutorials.net/lesson/area-of-triangle-csharp/

        public override Vector3 Center => center;

        public override float Circumference => circumference;

        public override string ToString() => $"triangle @({center}), p1({p1}), p2({p2}), p3({p3})";
    }
}
