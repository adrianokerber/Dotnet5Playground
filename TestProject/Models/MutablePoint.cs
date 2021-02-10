﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Models
{
    public struct MutablePoint
    {
        public int X;
        public int Y;

        public MutablePoint(int x, int y) => (X, Y) = (x, y);

        public override string ToString() => $"({X}, {Y})";
    }
}
