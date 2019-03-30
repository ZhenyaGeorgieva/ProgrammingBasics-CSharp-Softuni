using System;
    class Program
    {
        static void Main()
        {
        string type = Console.ReadLine();

        if (type == "square")
        {
            double squareSide = double.Parse(Console.ReadLine());
            double area = squareSide * squareSide;
            Console.WriteLine($"{area:F3}");
        }
        else if (type == "rectangle")
        {
            double rectangleSideA = double.Parse(Console.ReadLine());
            double rectangleSideB = double.Parse(Console.ReadLine());
            double area = rectangleSideA * rectangleSideB;
            Console.WriteLine($"{area:F3}");
        }
        else if (type == "circle")
        {
            double circleA = double.Parse(Console.ReadLine());
            double area = Math.PI * circleA * circleA;
            Console.WriteLine($"{area:F3}");
        }
        else if (type=="triangle")
        {
            double triangleSideA = double.Parse(Console.ReadLine());
            double triangleSideB = double.Parse(Console.ReadLine());
            double area = (triangleSideA * triangleSideB) / 2;
            Console.WriteLine($"{area:F3}");
        }
        }
    }

//Да се напише програма, в която потребителят въвежда вида и размерите на геометрична 
//фигура и пресмята лицето й. Фигурите са четири вида: квадрат (square), 
//правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). 
//На първия ред на входа се чете вида на фигурата (square, rectangle, circle или triangle). 
//Ако фигурата е квадрат, на следващия ред се чете едно число - дължина на страната му. 
//    Ако фигурата е правоъгълник, на следващите два реда четат две числа - дължините на
//    страните му. Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
//    Ако фигурата е триъгълник, на следващите два реда четат две числа - дължината на страната му 
//    и
//дължината на височината към нея. Резултатът да се закръгли до 3 цифри след десетичната точка. 