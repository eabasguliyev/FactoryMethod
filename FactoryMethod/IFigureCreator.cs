namespace FactoryMethod
{
    public interface IFigureCreator
    {
        IFigure CreateFigure(string formName, Rgb colorRgb);
    }
}