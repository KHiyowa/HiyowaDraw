using System.Collections.Generic;
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
        public Form menu = new MenuFm();

        //  フォームを開くとき
        private void DrawingFm_Load(object sender, System.EventArgs e)
        {
            menu.Show();
            setCaption();
        }

        //  フォームを閉じるとき
        private void DrawingFm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (savedState == false)
            {
                DialogResult result = MessageBox.Show(getFileName() + 
                    " は変更されています。保存しますか?",
                    "HiyowaDraw",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                //  Yesを選択した場合、保存する
                if (result == DialogResult.Yes)
                {
                    save(fileName);
                }
                //  キャンセルを選択した場合、終了をキャンセルする
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        public DrawingFm()
        {
            InitializeComponent();

            shapeList = new List<Shape>();
            currentShape = Shape.RECT;
            currentColor = Color.Blue;
        }

        //  ファイルを開く
        private void openTsmi_Click(object sender, EventArgs e)
        {
            open();
        }

        //  名前をつけて保存
        private void saveAsTsmi_Click(object sender, EventArgs e)
        {
            saveAs();
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
        private void colorTsmi_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                currentColor = cd.Color;
            }
        }

        private void quitTsmi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
