class Circle
{
    
    double radius = Convert.ToInt32(Console.ReadLine());
    double PI = 3.14159;

    public Circle(int radius)
    {
        this.radius = radius;
    }
    public void Constructor()
    {
        radius = 0.0;
    }
    public string GetArea()
    {
        return  $"area = {PI * radius * radius}";
    }
    public string GetDiameter()
    {
        return $"diameter = {radius * 2}";
    }
    public string GetCircumference()
    {
        return $"circumference = {2 * PI * radius}";
    }
}