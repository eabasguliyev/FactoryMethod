using FactoryMethod.OneSidedTetrominoes;
using System;

namespace FactoryMethod
{
    class Program
    {
        // 

        static void Main(string[] args)
        {
            IFigureCreator figureCreator = new TetrominoFactory();

            IFigure figure = figureCreator.CreateFigure("T", new Rgb(120, 250, 200));

            figure.ShowFigure();
        }
    }
}
