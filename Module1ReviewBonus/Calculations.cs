namespace Module1ReviewBonus;

public partial class Calculations
{
    // Circle Area Method:
    // Create a method that calculates the area of a circle.
    //     Use a parameter called radius of type double.
    // Look up the formula for each method and implement the logic in the scope.
    //     You are encouraged to research online to find the formula.
    //     Commit your work.

    public void CircleArea()
    {
        Console.WriteLine("What is the radius of your circle?");
        double radius = Convert.ToDouble(Console.ReadLine());
        double areaofcircle = Math.PI * radius * radius;
        Console.WriteLine($"The area of your circle is {areaofcircle}");
    }
    //     Triangle Area Method:
    // Create a method that calculates the area of a triangle.
    //     Use 2 parameters called baseLength and height of type double.
    // Look up the formula for each method and implement the logic in the scope.
    //     You are encouraged to research online to find the formula.
    //     Commit your work.
    public void TriangleArea()
    {
        Console.WriteLine("How long is the side 1 of your triangle?");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How long is the side 2 of your triangle?");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How long is the side 3 of your triangle?");
        double side3 = Convert.ToDouble(Console.ReadLine());
        double semiperimeter = (side1 + side2 + side3) / 2;
        double areaoftriangle = Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        Console.WriteLine($"The area of your triangle is {areaoftriangle}");
    }
    
    //     Rectangle Area Method:
    // Create a method that calculates the area of a rectangle.
    //     Use 2 parameters called length and width of type double.
    // Look up the formula for each method and implement the logic in the scope.
    //     You are encouraged to research online to find the formula.
    //     Commit your work.

    public void RectangleArea()
    {
        Console.WriteLine("How long is the long side of your rectangle?");
        double longside = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("How long is the short side of your rectangle?");
        double shortside = Convert.ToDouble(Console.ReadLine());
        double areaofrectangle = (longside * shortside);
        Console.WriteLine($"The area of your rectangle is {areaofrectangle}");
    }
    //     Square Area Method:
    // Create a method that calculates the area of a square.
    //     Use a variable called side of type double.
    // Look up the formula for each method and implement the logic in the scope.
    //     You are encouraged to research online to find the formula.
    //     Commit your work.

    public void SquareArea()
    {
        Console.WriteLine("How long is one side of your square?");
        double squareside = Convert.ToDouble(Console.ReadLine());
        double areaofsquare = (squareside * squareside);
        Console.WriteLine($"The area of your square is {areaofsquare}!");
    }
}