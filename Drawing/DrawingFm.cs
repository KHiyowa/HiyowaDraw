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
        public Form menu = new MenuFm();
        private void DrawingFm_Load(object sender, System.EventArgs e)
        {
            menu.Show();
            setCaption();
        }
        public DrawingFm()
        {
            InitializeComponent();

            shapeList = new List<Shape>();
            currentShape = Shape.RECT;
            currentColor = Color.Blue;

            MouseDown += new MouseEventHandler(DrawingFm_MouseDown);
            MouseUp += new MouseEventHandler(DrawingFm_MouseUp);
            Paint += new PaintEventHandler(DrawingFm_Paint);
            pd.PrintPage += new PrintPageEventHandler(DrawingFm_PrintPage);
        }

        //  ファイルを開く
        private void openTsmi_Click(object sender, EventArgs e)
        {
            //  フロートメニューを隠す
            menu.Hide();
            ofd.Filter = "HiyowaDraw グラフィックス|*.hdg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ofd.FileName,
                    FileMode.Open, FileAccess.Read);
                shapeList.Clear();
                shapeList = (List<Shape>)bf.Deserialize(fs);
                fs.Close();
                this.Invalidate();
                fileName = ofd.FileName;
                setCaption();
            }

            //  フロートメニューを再表示
            menu.Show();
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