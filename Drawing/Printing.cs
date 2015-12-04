using System.Drawing;
using System.Drawing.Printing;

namespace Drawing
{
    public partial class DrawingFm
    {
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Shape sh in shapeList)
            {
                sh.Draw(g);
            }
        }

    }
}
