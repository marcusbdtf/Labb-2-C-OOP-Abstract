using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace class_Shape
{
    public class Sphere : Shape3D
    {
        public Vector3 center;
        public float radius;
        public float area;
        public float volume;

        public Sphere(Vector3 center)
        {
            this.center = center;
            this.area = (4 * PI) * (float)Math.Pow(radius, 2);
            this.volume = ((4 / 3) * PI) * (float)Math.Pow(radius, 3);
        }
        public Sphere(Vector3 center, float radius)
        {
            this.center = center; 
            this.radius = radius;
            this.area = (4 * PI) * (float)Math.Pow(radius, 2);
            this.volume = ((4 / 3) * PI) * (float)Math.Pow(radius, 3);
        }

        public override float Area => area;

        public override Vector3 Center => center;

        public override float Volume => volume;

        public override string ToString() => $"sphere @({center}): r = {radius}";
    }
}
