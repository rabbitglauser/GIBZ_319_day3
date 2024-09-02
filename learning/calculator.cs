public class Rectangle
{
    private double _width = 22;
    private double _height =  9;
    
    //defining the width and the height in my methode
    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
        Console.WriteLine("Welcome to the Rectangle Calculator!");
    }


    /// Prompts the user to enter the width and height of the rectangle,
    /// and sets the respective properties with the provided values.
    /// Function will request user input and converts it to double values
    /// to update the dimensions of the rectangle.
    public void GetDimensionsFromUser()
    {
        Console.Write("Please enter the width of the rectangle: ");
        string widthInput = Console.ReadLine();
        _width = Convert.ToDouble(widthInput);
        Console.Write("Please enter the height of the rectangle: ");
        string heightInput = Console.ReadLine();
        _height = Convert.ToDouble(heightInput);
    }

  
    /// Calculates and prints the perimeter of the rectangle
    /// using the width and height properties.
    public void CalculatePerimeter()
    {
        double perimeter = 2 * (_width + _height);
        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
    }
    
    /// Calculates the area of the rectangle using its width and height, and outputs the result to the console.
    public void CalculateArea()
    {
        double area = _width * _height;
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}

