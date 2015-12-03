using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Drawing
{
    public partial class DrawingFm : Form
    {
        public Form menu = new MenuFm();
        private void DrawingFm_Load(object sender, System.EventArgs e)
        {
            menu.Show();
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
    }
}
