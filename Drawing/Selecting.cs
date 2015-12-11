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
        public int selectMode;

        abstract public class SelectMode
        {
            public static int MOVE = 0;
            public static int ERASE = 1;
            public static int FRONT = 2;
            public static int BACK = 3;
        }

        //  選択用の破線矩形
        class SelectRect : Shape
        {
            public override void Draw(Graphics g)
            {
                Pen p = new Pen(Color.Blue, 10);
                p.DashStyle = DashStyle.Dash;
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
            }
        }

        //  選択モード
        private void selectModeMouseDown(MouseEventArgs e)
        {

            for (int i = shapeList.Count - 1; i >= 0; i--)
            {
                Shape sh =
                    (Shape)(shapeList[i] as Shape);
                Point sp = sh.GetStartPoint();
                Point ep = sh.GetEndPoint();
                if (e.X > sp.X && e.X < ep.X && e.Y > sp.Y && e.Y < ep.Y)
                {
                    if (selectMode == SelectMode.MOVE)
                    {
                        select = new SelectRect();
                        select.SetStartPoint(sp.X, sp.Y);
                        select.SetEndPoint(ep.X, ep.Y);
                    }
                    else if (selectMode == SelectMode.ERASE)
                    {
                        erase(i);
                    }
                    this.Invalidate();
                    break;
                }
            }
        }

        private void move(int position, MouseEventArgs e)
        {
            Shape sh = (Shape)(shapeList[position] as Shape);
            Point sp = sh.GetStartPoint();
            Point ep = sh.GetEndPoint();

            Point dp = new Point(e.X - sp.X, e.Y - sp.Y);

            sh.SetStartPoint(e.X + dp.X, e.Y + dp.Y);
        }

        private void erase(int position)
        {
            undoPush(Cancellation.ERASE, position, shapeList[position]);
            shapeList.RemoveAt(position);
        }
    }
}
