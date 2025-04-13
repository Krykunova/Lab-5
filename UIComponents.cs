using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IUIComponent
    {
        void Render();
    }

    public class Button : IUIComponent
    {
        private string _label;

        public Button(string label)
        {
            _label = label;
        }

        public void Render()
        {
            Console.WriteLine($"Кнопка: {_label}");
        }
    }

    public class Panel : IUIComponent
    {
        private List<IUIComponent> _children = new List<IUIComponent>();

        public void Add(IUIComponent component)
        {
            _children.Add(component);
        }

        public void Render()
        {
            Console.WriteLine("Панель:");
            foreach (var child in _children)
            {
                child.Render();
            }
        }
    }
}
