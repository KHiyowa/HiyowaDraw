using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Cancellation cs = undo.Pop();
            if (cs.getEditType() == EditType.DRAW)
            {
                shapeList.RemoveAt(cs.getPosition());
                // cs.setEditType(EditType.ERASE);
                redo.Push(cs);
            }
            else if (cs.getEditType() == EditType.ERASE)
            {
                shapeList.Insert(cs.getPosition(), cs.getShape());
                // cs.setEditType(EditType.DRAW);
                redo.Push(cs);
            }
            this.Invalidate();
        }
        #endregion
    }
}
