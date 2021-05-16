namespace FactoryMethod
{
    public interface IFigure
    {
        string Name { get; set; }
        Rgb Color { get; set; }
        byte[][] Form { get; set; }


        void ShowFigure();
    }
}