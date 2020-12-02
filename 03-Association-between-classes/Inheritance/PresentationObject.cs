using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object was duplicated");
        }
    }
}