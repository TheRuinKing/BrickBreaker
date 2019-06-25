﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    public class Bouncer
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Point Position { get; set; }
        public Color Coloring { get; set; }
        public double Speed { get; set; }

        public Bouncer(float width, float height, Point position, Color coloring)
        {
            Width = width;
            Height = height;
            Position = position;
            Coloring = coloring;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Coloring);
            g.FillRectangle(brush, Position.X, Position.Y, Width, Height);
        }
    }
}
