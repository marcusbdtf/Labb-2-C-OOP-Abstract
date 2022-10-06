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
        public Shape()
        {
            
        }
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
       
        public const float PI = (float)Math.PI; // implementing math.pi in float format in base Class so all Classes have access to it. 



        public static Shape GenerateShape()
        {
            Random random = new Random();
            int n = random.Next(0, 7);


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

                case 6: //2d
                    return new Triangle(size, center, third3);

                default: throw new ArgumentOutOfRangeException();
            }
           
        }
        public static Shape GenerateShape(Vector3 argCenter)
        {
            Random random = new Random();
            int n = random.Next(0, 7);


            float x = (float)random.Next(1, 11);
            float y = (float)random.Next(1, 11);
            float z = (float)random.Next(1, 11);
            float r = (float)random.Next(1, 11);
            Vector2 center = new Vector2(x, y);
            Vector3 center3 = new Vector3(x, y, z);

            float w = (float)random.Next(1, 11);
            float h = (float)random.Next(1, 11);
            Vector2 size = new Vector2(w, h);

            float a = (float)random.Next(1, 11);
            float b = (float)random.Next(1, 11);
            float c = (float)random.Next(1, 11);
            Vector2 third3 = new Vector2(a, b);
            Vector3 size3d = new Vector3(a, b, c);

            Vector2 centerNew = new Vector2(argCenter.X, argCenter.Y);

            switch (n)
            {
                case 0: //2d
                    return new Circle(centerNew, r);

                case 1: //3d
                    return new Sphere(argCenter, r);

                case 2: //2d
                    return new Rectangle(centerNew, size);

                case 3: //2d
                    return new Rectangle(centerNew, r); // SQUARE

                case 4: //3d
                    return new Cuboid(argCenter, r); // CUBE

                case 5: //3d
                    return new Cuboid(argCenter, size3d);

                case 6: //2d
                    return new Triangle(size, center, third3); // needs 3 points can't give center a

                default: throw new ArgumentOutOfRangeException();
            }

        }


    }
}