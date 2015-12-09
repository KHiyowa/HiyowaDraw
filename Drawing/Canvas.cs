using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class DrawingFm
    {
        //  元に戻す/やり直しのスタック
        public static Stack<Cancellation> undoStack;
        public static Stack<Cancellation> redoStack;

        abstract private class EditType
        {
            public static int DRAW = 0;
            public static int ERASE = 1;
            public static int MODIFY = 2;
        }

        public class Cancellation
        {
            public static int edittype;
            public static int position;
            public static Shape shape;
            public int getEditType()
            {
                return edittype;
            }
            public void setEditType(int type)
            {
                edittype = type;
            }
            public int getPosition()
            {
                return position;
            }
            public void setPosition(int pos)
            {
                position = pos;
            }
            public Shape getShape()
            {
                return shape;
            }
            public void setShape(Shape sh)
            {
                shape = sh;
            }
        }

        //  新規作成
        private void newCanvas()
        {
            //  リストを初期化
            shapeList = new List<Shape>();
            undoStack = new Stack<Cancellation>();
            redoStack = new Stack<Cancellation>();

            //  保存状態をクリア
            savedState = true;
            //  ファイル名をクリア
            fileName = null;

            //  再描画
            this.Invalidate();
            setCaption();
        }

        //  キャンバスのサイズを取得する
        private Size getCanvasSize()
        {
            return new Size(this.ClientSize.Width, 
                this.ClientSize.Height - commandBarMs.Height - statusBarSs.Height);
        }

        //  ステータスバーにキャンバスサイズを表示する
        private void indicateCanvasSize()
        {
            Size canvasSize = getCanvasSize();
            canvasXTssl.Text = "X = " + canvasSize.Width.ToString();
            canvasYTssl.Text = "Y = " + canvasSize.Height.ToString();
        }

        #region UndoRedo
        //  元に戻す
        public void undo()
        {
            cancellation(undoStack, redoStack);
        }

        //  やり直し
        public void redo()
        {
            cancellation(redoStack, undoStack);
        }

        public void cancellation(Stack<Cancellation> undo, Stack<Cancellation> redo)
        {
            if (undo.Count == 0) { return; }
            Cancellation sh = undo.Pop();
            if (sh.getEditType() == EditType.DRAW)
            {
                shapeList.RemoveAt(sh.getPosition());
                sh.setEditType(EditType.ERASE);
                redo.Push(sh);
            }
            else if (sh.getEditType() == EditType.ERASE)
            {
                shapeList.Insert(sh.getPosition(), sh.getShape());
                sh.setEditType(EditType.DRAW);
                redo.Push(sh);
            }
            this.Invalidate();
        }
        #endregion
    }
}
