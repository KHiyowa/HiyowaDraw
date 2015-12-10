using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    //  選択モードに関するメソッド名

    public partial class DrawingFm
    {
        Shape select = null;

        //  選択用の破線矩形
        class SelectRect : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(Color.Blue, 5);
                p.DashStyle = DashStyle.Dash;
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        //  選択モード
        private void selectModeMouseMove(MouseEventArgs e)
        {

            for (int i = shapeList.Count - 1; i >= 0; i--)
            {
                Shape sh =
                    (Shape)(shapeList[i] as Shape);
                Point sp = sh.GetStartPoint();
                Point ep = sh.GetEndPoint();
                if (e.X > sp.X && e.X < ep.X && e.Y > sp.Y && e.Y < ep.Y)
                {
                    if (dragState)
                    {
                        moveSelectingShape(i, e);
                    }
                    select = new SelectRect();
                    select.SetStartPoint(sp.X, sp.Y);
                    select.SetEndPoint(ep.X, ep.Y);
                    this.Invalidate();
                    break;
                }
            }
        }

        private void moveSelectingShape(int position, MouseEventArgs e)
        {
            Shape sh = (Shape)(shapeList[position] as Shape);
            Point sp = sh.GetStartPoint();
            Point ep = sh.GetEndPoint();

            Point dp = new Point(e.X - sp.X, e.Y - sp.Y);

            sh.SetStartPoint(e.X + dp.X, e.Y + dp.Y);
        }
    }
}
