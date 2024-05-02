using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xagros.GUI
{
    public class Window
    {
        public Window(int x, int y, int w, int h, string title, string content = "")
        {
            Kernel.Canvas.DrawRectangle(new Pen(Color.White), x - 1, y - 1, w, h);
            Kernel.Canvas.DrawRectangle(new Pen(Color.Black), x + 1, y, w - 1, h);
            Kernel.Canvas.DrawFilledRectangle(new Pen(Color.LightGray), x, y, w, h);
            Kernel.Canvas.DrawFilledRectangle(new Pen(Color.DarkBlue), x + 1, y + 1, w - 2, 21);

            // Titlebar
            Kernel.Canvas.DrawString(title, Kernel.DefaultFont, new Pen(Color.White), x + 7, y + 4);

            // Content
            Kernel.Canvas.DrawString(content, Kernel.DefaultFont, new Pen(Color.Black), x + 7 + 4, y + 4 + 25);


        }
    }
}

