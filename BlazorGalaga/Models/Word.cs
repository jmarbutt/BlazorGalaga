﻿using System;
using System.Drawing;

namespace BlazorGalaga.Models
{
    public class Word
    {
        public string TextString { get; set; }
        public PointF Location { get; set; }
        public BezierCurve Path { get; set; }
        public bool DrawPath { get; set; }
    }
}
