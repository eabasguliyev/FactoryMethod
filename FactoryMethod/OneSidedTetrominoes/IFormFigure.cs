using System;

namespace FactoryMethod.OneSidedTetrominoes
{
    public class IFormFigure : IFigure
    {
        public string Name { get; set; }
        public Rgb Color { get; set; }
        public byte[][] Form { get; set; }

        public IFormFigure(Rgb color)
        {
            Name = "I form";
            Color = color;
            Form = new byte[][]
            {
                new Byte[] {1, 1, 1, 1},
                new Byte[] {0, 0, 0, 0},
                new Byte[] {0, 0, 0, 0},
                new Byte[] {0, 0, 0, 0},
            };
        }

        public void ShowFigure()
        {
            Console.WriteLine($"Figure name: {Name}");
        }
    }

}
