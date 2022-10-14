using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b) => a * b;
        public double CylinderVolume(int r, int h) => Math.Round(Math.PI * r * r * h);
        
    }
}
