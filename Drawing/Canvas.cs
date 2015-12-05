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
        //  新規作成
        private void newCanvas()
        {
            //  リストを初期化
            shapeList = new List<Shape>();
            redoStack = new Stack<Shape>();
            //  デフォルトの図形と色を設定
            currentShape = Shape.RECT;
            currentColor = Color.Blue;
            shapeFilled = true;
            lineWidth = 2;

            //  保存状態をクリア
            savedState = true;
            //  ファイル名をクリア
            fileName = null;

            //  再描画
            setCaption();
        }

        //  ステータスバーにキャンバスサイズを表示する
        private void indicateCanvasSize()
        {
            Size canvasSize = this.ClientSize;
            canvasXTssl.Text = "X = " + canvasSize.Width.ToString();
            canvasYTssl.Text = "Y = " + (canvasSize.Height - commandBarMs.Height).ToString();
        }

        public static void undo()
        {
            if (shapeList.Count == 0) { return; }
            redoStack.Push(shapeList[shapeList.Count - 1]);
            shapeList.RemoveAt(shapeList.Count - 1);
        }
        public static void redo()
        {
            shapeList.Add(redoStack.Pop());
        }
    }
}
