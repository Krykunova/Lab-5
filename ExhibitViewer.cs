using System;

namespace ConsoleApp1
{
    public abstract class ExhibitViewer
    {
        public abstract void Display();
    }

    public class Viewer2D : ExhibitViewer
    {
        public override void Display()
        {
            Console.WriteLine("Перегляд експоната у 2D.");
        }
    }

    public class Viewer3D : ExhibitViewer
    {
        public override void Display()
        {
            Console.WriteLine("Перегляд експоната у 3D.");
        }
    }

    public abstract class ExhibitViewerFactory
    {
        public abstract ExhibitViewer CreateViewer();
    }

    public class Viewer2DFactory : ExhibitViewerFactory
    {
        public override ExhibitViewer CreateViewer()
        {
            return new Viewer2D();
        }
    }

    public class Viewer3DFactory : ExhibitViewerFactory
    {
        public override ExhibitViewer CreateViewer()
        {
            return new Viewer3D();
        }
    }
}
