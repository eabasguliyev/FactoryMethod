using System;

namespace FactoryMethod.OneSidedTetrominoes
{
    public class TetrominoFactory : IFigureCreator
    {
        public IFigure CreateFigure(string formName, Rgb colorRgb)
        {
            return formName switch
            {
                "I" => new OFormFigure(colorRgb),
                "O" => new OFormFigure(colorRgb),
                "T" => new TFormFigure(colorRgb),
                "J" => new JFormFigure(colorRgb),
                "L" => new LFormFigure(colorRgb),
                "S" => new SFormFigure(colorRgb),
                _ => throw new ArgumentOutOfRangeException(nameof(formName), formName, "Not implemented form")
            };
        }
    }
}