var obw = new Rectangle();
obw.Height = 100;
obw.Width = 150;


System.Console.WriteLine($"{obw.GetArea()} {obw.GetPerimeter()}");
public class Rectangle
{
    public int Width;
    public int Height;
    

    public string GetArea()
    {
        return $"{Width * Height}";
    }
     public string GetPerimeter()
    {
        return $"{2 * (Width + Height)}";
    }
}