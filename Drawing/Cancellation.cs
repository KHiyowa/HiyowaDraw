using System;
using System.Collections.Generic;

namespace Drawing
{
    public partial class DrawingFm
    {
        //  元に戻す/やり直しのスタック
        public static Stack<Cancellation> undoStack;
        public static Stack<Cancellation> redoStack;

        [Serializable]
        public class Cancellation
        {
            public static int DRAW = 0;
            public static int ERASE = 1;
            public static int MODIFY = 2;

            protected int edittype;
            protected int position;
            protected Shape shape;

            public int GetEditType()
            {
                return edittype;
            }
            public void SetEditType(int edittype)
            {
                this.edittype = edittype;
            }
            public int GetPosition()
            {
                return position;
            }
            public void SetPosition(int position)
            {
                this.position = position;
            }
            public Shape GetShape()
            {
                return shape;
            }
            public void SetShape(Shape shape)
            {
                this.shape = shape;
            }
        }

        //  undoスタックへのプッシュ
        public void undoPush(int edittype, int position, Shape shape)
        {
            Cancellation cs = new Cancellation();
            cs.SetEditType(edittype);
            cs.SetPosition(position);
            cs.SetShape(shape);
            undoStack.Push(cs);
            redoStack.Clear();
        }

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
            if (Cancellation.DRAW == cs.GetEditType())
            {
                shapeList.RemoveAt(cs.GetPosition());
                cs.SetEditType(Cancellation.ERASE);
                redo.Push(cs);
            }
            else if (Cancellation.ERASE == cs.GetEditType())
            {
                shapeList.Insert(cs.GetPosition(), cs.GetShape());
                cs.SetEditType(Cancellation.DRAW);
                redo.Push(cs);
            }
            this.Invalidate();
        }
    }
}
