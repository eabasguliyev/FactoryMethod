using System;

namespace FactoryMethod.OneSidedTetrominoes
{
    public class JFormFigure : IFigure
    {
        public string Name { get; set; }
        public Rgb Color { get; set; }
        public byte[][] Form { get; set; }

        public JFormFigure(Rgb color)
        {
            Name = "J form";
            Color = color;
            Form = new byte[][]
            {
                new Byte[] {0, 1, 0, 0},
                new Byte[] {0, 1, 0, 0},
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
