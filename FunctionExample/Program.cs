// variables for rectangle 1
double rect1x1 = 4.5;
double rect1y1 = 2.3;
double rect1x2 = 8.2;
double rect1y2 = 4.9;

// area of rectangle 1
double area1 = Math.Abs((rect1x1 - rect1x2) * (rect1y1 - rect1y2));
Console.WriteLine($"Area of first rectangle is {area1}");


// variables for rectangle 2
double rect2x1 = -3.2;
double rect2y1 = 1.1;
double rect2x2 = 3.7;
double rect2y2 = 5.6;

// area of rectangle 2
double area2 = Math.Abs((rect2x1 - rect2x2) * (rect2y1 - rect2y2));
Console.WriteLine($"Area of second rectangle is {area2}");


// printing the variables of rectangle 1 and 2 to the console to compare and check if AreaOfRectangle does as intended
Console.WriteLine("the area of AreaOfRectangle is " + AreaOfRectangle(rect1x1, rect1y1, rect1x2, rect1y2));
Console.WriteLine("the area of AreaOfRectangle is " + AreaOfRectangle(rect2x1, rect2y1, rect2x2, rect2y2));
Console.WriteLine("the area of AreaOfRectangleAlternative is " + AreaOfRectangleAlternative(rect1x1, rect1y1, rect1x2, rect1y2));
Console.WriteLine("the area of AreaOfRectangleAlternative is " + AreaOfRectangleAlternative(rect2x1, rect2y1, rect2x2, rect2y2));


// method for finding the area of rectangles
double AreaOfRectangle(double x1, double y1, double x2, double y2)
{


    // values for easy readability
    double ValueOfX = x1 - x2;
    double ValueOfY = y1 - y2;

    // calculate area of a rectangle
    double areaOfRectangle = Math.Abs(ValueOfX * ValueOfY);

    // return areaOfRectangle
    return areaOfRectangle;
}


// alternative way of writing the code with same result aka. refactored. også kendt som omstruktureret

double AreaOfRectangleAlternative(double x1, double y1, double x2, double y2)
{
    // returns the calculated area of a rectangle
    return Math.Abs((x1 - x2) * (y1 - y2));
}




