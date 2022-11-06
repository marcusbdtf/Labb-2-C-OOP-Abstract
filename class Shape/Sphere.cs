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
        public float radius { get; }
        public float area { get { return 4 * MathF.PI * radius * radius; } }
        public float volume { get { return (4f / 3f) * MathF.PI * radius * radius * radius; } }

        public Sphere(Vector3 center)
        {
            this.center = center;
        }
        public Sphere(Vector3 center, float radius)
        {
            this.center = center; 
            this.radius = radius;
        }

        public override float Area => area;

        public override Vector3 Center => center;

        public override float Volume => volume;

        public override string ToString() => $"sphere @({center}): r = {radius}";
    }
}
