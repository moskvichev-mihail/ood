using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Window;
using SFML.System;
using Figures.FigDecorator;
using Figures.CommandController;

namespace GeomFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RenderWindow win = new RenderWindow(new VideoMode(800, 600), "FiguresLab1");
            Controller controller = new Controller("input.txt", "output.txt");
            controller.Print();

            while (win.IsOpen)
            {
                win.DispatchEvents();
                win.Clear(Color.Black);
                controller.DrawFigures(win);
                win.Display();

            }

        }
    }
}
