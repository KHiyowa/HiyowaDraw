using System;
using System.Collections.Generic;
using System.Drawing;

namespace Drawing
{
    public partial class DrawingFm
    {
        public static List<Shape> shapeList;
        public static Stack<Shape> redoStack;

        [Serializable]
        abstract public class Shape
        {
            public static int RECT = 0;
            public static int OVAL = 1;
            public static int LINE = 2;
            protected int x1, y1, x2, y2;
            protected Color ec;
            protected Color fc;
            protected int w;

            abstract public void Draw(Graphics g);

            public void SetColor(Color ec, Color fc)
            {
                this.ec = ec;
                this.fc = fc;
            }
            public void SetWidth(int w)
            {
                this.w = w;
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
        class OutlineRect : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(ec, w);
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class FillRect : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(fc);
                Pen p = new Pen(ec, w);
                g.FillRectangle(sb, x1, y1, x2 - x1, y2 - y1);
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class OutlineOval : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(ec, w);
                g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class FillOval : Shape
        {
            public override void Draw(Graphics g)
            {
                SolidBrush sb = new SolidBrush(fc);
                Pen p = new Pen(ec, w);
                g.FillEllipse(sb, x1, y1, x2 - x1, y2 - y1);
                g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        [Serializable]
        class Line : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(ec, w);
                g.DrawLine(p, x1, y1, x2, y2);
            }
        }
    }
}
