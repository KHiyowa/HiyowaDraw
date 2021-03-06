﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Drawing
{
    public partial class DrawingFm : Form
    {
        public static string fileName;
        public Form menu;

        public DrawingFm()
        {
            InitializeComponent();

            //  デフォルトの図形と色を設定
            currentMode = Mode.DRAW;
            currentShape = Shape.RECT;
            currentEdgeColor = Color.Black;
            currentFillColor = Color.Blue;
            shapeFilled = true;
            lineWidth = 2;
            //  新しいキャンバスを作成
            newCanvas();
        }

        //  フォームを開くとき
        private void DrawingFm_Load(object sender, System.EventArgs e)
        {
            menu = new MenuFm(this);
            menu.Show();
            setCaption();
            indicateCanvasSize();
        }

        //  フォームを閉じるとき
        private void DrawingFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Hide();
            if (savedState == false)
            {
                DialogResult result = confirmSave();

                //  Yesを選択した場合、保存する
                if (result == DialogResult.Yes)
                {
                    save(fileName);
                }
                //  キャンセルを選択した場合、終了をキャンセルする
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    menu.Show();
                }
            }
        }

        //  ファイルを開く
        private void openTsmi_Click(object sender, EventArgs e)
        {
            menu.Hide();
            open();
            menu.Show();
        }

        //  名前をつけて保存
        private void saveAsTsmi_Click(object sender, EventArgs e)
        {
            menu.Hide();
            saveAs();
            menu.Show();
        }

        private void saveTsmi_Click(object sender, EventArgs e)
        {
            save(fileName);
        }

        //  印刷プレビュー
        private void printPreviewTsmi_Click(object sender, EventArgs e)
        {
            pp.Document = pd;
            pp.ShowDialog();
        }

        //  印刷
        private void printTsmi_Click(object sender, EventArgs e)
        {
            pd.Print();
        }

        //  元に戻す
        private void undoTsmi_Click(object sender, EventArgs e)
        {
            undo();
        }

        //  やり直し
        private void redoTsmi_Click(object sender, EventArgs e)
        {
            redo();
        }

        //  四角
        private void rectTsmi_Click(object sender, EventArgs e)
        {
            currentShape = Shape.RECT;
        }

        //  丸
        private void ovalTsmi_Click(object sender, EventArgs e)
        {
            currentShape = Shape.OVAL;
        }

        //  線
        private void lineTsmi_Click(object sender, EventArgs e)
        {
            currentShape = Shape.LINE;
        }

        //  色設定
        private void edgeColorTsmi_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentEdgeColor = cd.Color;
            }
        }
        private void fillColorTsmi_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentFillColor = cd.Color;
            }
        }

        //  終了
        private void quitTsmi_Click(object sender, EventArgs e)
        {
            Close();
        }

        //  リサイズ
        private void DrawingFm_Resize(object sender, EventArgs e)
        {
            indicateCanvasSize();
        }

        //  新規作成
        private void newTsmi_Click(object sender, EventArgs e)
        {
            menu.Hide();
            //  保存されていなければ確認
            if (savedState != true)
            {
                DialogResult result = confirmSave();

                //  Yesを選択した場合、保存する
                if (result == DialogResult.Yes)
                {
                    save(fileName);
                }
                //  キャンセルを選択した場合、新規作成をキャンセルする
                else if (result == DialogResult.Cancel)
                {
                    menu.Show();
                    return;
                }
            }
            newCanvas();
            menu.Show();
        }

        private void exportTsmi_Click(object sender, EventArgs e)
        {
            menu.Hide();
            exportBmp();
            menu.Hide();
        }
    }
}
