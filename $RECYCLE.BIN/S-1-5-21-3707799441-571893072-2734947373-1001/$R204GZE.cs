using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225468_NguyenHuuTai_DesignPattern01_Composite_Structural
{
    public class Composite : DrawingElement
    {
        List<DrawingElement> children = new List<DrawingElement>();
        // Constructor
        public Composite(string name)
            : base(name)
        {
        }
        public override void Add(DrawingElement component)
        {
            children.Add(component);
        }
        public override void Remove(DrawingElement component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            // Recursively display child nodes
            foreach (DrawingElement component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
