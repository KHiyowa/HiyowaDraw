using System;
using System.Collections.Generic;
using System.Drawing;

namespace Drawing
{
    public partial class DrawingFm
    {
        private List<Shape> shapeList;

        [Serializable]
        abstract class Shape
        {
            public static int RECT = 0;
            public static int OVAL = 1;
            public static int LINE = 2;
            protected int x1, y1, x2, y2;
            protected Color c;

            abstract public void Draw(Graphics g);

            public void SetColor(Color c)
            {
                this.c = c;
            }
            public void SetStartPoint(int x, int y)
            {
                x1 = x; y1 = y;
            }
            public void SetEndPoint(int x, int y)
            {
                x2 = x; y2 = y;
            }
        }

        [Serializable]
        class Rect : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(c);
                g.FillRectangle(sb, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class Oval : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(c);
                g.FillEllipse(sb, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class Line : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(c);
                Pen p = new Pen(sb);
                g.DrawLine(p, x1, y1, x2, y2);
            }
        }
    }
}
