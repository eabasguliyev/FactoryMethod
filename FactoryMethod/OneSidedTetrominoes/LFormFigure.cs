using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.OneSidedTetrominoes
{

    public class LFormFigure : IFigure
    {
        public string Name { get; set; }
        public Rgb Color { get; set; }
        public byte[][] Form { get; set; }

        public LFormFigure(Rgb color)
        {
            Name = "L form";
            Color = color;
            Form = new byte[][]
            {
                new Byte[] {1, 0, 0, 0},
                new Byte[] {1, 0, 0, 0},
                new Byte[] {1, 1, 0, 0},
                new Byte[] {0, 0, 0, 0},
            };
        }

        public void ShowFigure()
        {
            Console.WriteLine($"Figure name: {Name}");
        }
    }

}
