using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int Lanes { get; set; }
        public int CurrentTrafficLevel { get; set; }

        public Road(double length, double width, int lanes)
        {
            Length = length;
            Width = width;
            Lanes = lanes;
            CurrentTrafficLevel = 0;
        }

    }
}
