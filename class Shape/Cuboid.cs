using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace class_Shape
{
    public class Cuboid : Shape3D
    {
        public Vector3 center;
        public Vector3 size;
        public bool IsCube
        {
            get { return size.X == size.Y && size.Y == size.Z; }
        }
        
        public float area { get { return 2 * (size.X * size.Y + size.X * size.Z + size.Y * size.Z); } }
        public float volume
        {
            get { return size.X * size.Y * size.Z; }
        }


        public Cuboid(Vector3 center)
        {
            this.center = center;
        }

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.size.X = width;
            this.size.Y = width;
            this.size.Z = width;
        }

        public override float Volume => volume;

        public override float Area => area;
        
        public override Vector3 Center => center;

        public override string ToString() => IsCube == false ? $"cuboid @ ({size.X},{size.Y},{size.Z}): w = {size.X} | h = {size.Y} | l = {size.Z}" : $"cube @ ({size.X},{size.Y},{size.Z}): w = {size.X} | h = {size.Y} | l = {size.Z}";

    }
}
