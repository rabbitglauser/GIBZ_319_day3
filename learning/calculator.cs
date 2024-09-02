public class Rectangle
{
    private double _width = 22;
    private double _height =  9;
    
    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
        Console.WriteLine("Welcome to the Rectangle Calculator!");
    }
    
    public void GetDimensionsFromUser()
    {
        Console.Write("Please enter the width of the rectangle: ");
        string widthInput = Console.ReadLine();
        _width = Convert.ToDouble(widthInput);
        Console.Write("Please enter the height of the rectangle: ");
        string heightInput = Console.ReadLine();
        _height = Convert.ToDouble(heightInput);
    }

    public void CalculatePerimeter()
    {
        double perimeter = 2 * (_width + _height);
        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
    }
    
    public void CalculateArea()
    {
        double area = _width * _height;
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}

