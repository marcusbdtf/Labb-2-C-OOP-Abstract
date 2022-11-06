using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Security.AccessControl;

namespace class_Shape
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Random random = new Random();
            int n = random.Next(0, 6);


            float x = (float)random.Next(2, 12);
            float y = (float)random.Next(2, 12);
            float z = (float)random.Next(2, 12);
            float r = (float)random.Next(2, 12);
            Vector2 center = new Vector2(x, y);
            Vector3 center3 = new Vector3(x, y, z);

            float w = (float)random.Next(2, 12);
            float h = (float)random.Next(2, 12);
            Vector2 size = new Vector2(w, h);

            float a = (float)random.Next(2, 12);
            float b = (float)random.Next(2, 12);
            float c = (float)random.Next(2, 12);
            Vector2 third3 = new Vector2(a, b);
            Vector3 size3d = new Vector3(a, b, c);

            switch (n)
            {
                case 0: //2d
                    return new Circle(center, r);

                case 1: //3d
                    return new Sphere(center3, r);

                case 2: //2d
                    return new Rectangle(center, size);

                case 3: //2d
                    return new Rectangle(center, r); // SQUARE
                
                case 4: //3d
                    return new Cuboid(center3, r); // CUBE

                case 5: //3d
                    return new Cuboid(center3, size3d); 

                default: throw new ArgumentOutOfRangeException();
            }
           
        }
    }
}