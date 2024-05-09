namespace Assignment_13._1._1
{
    class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape to calculate its area:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateTriangleArea();
                    break;
                case 2:
                    CalculateSquareArea();
                    break;
                case 3:
                    CalculateRectangleArea();
                    break;
                default:
                    Console.WriteLine("Choose 1, 2, or 3.");
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter the base length of the triangle:");
            double triangleBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = .5 * triangleBase * height;

            Console.WriteLine("Area of the triangle is: " + area);
        }

        static void CalculateSquareArea()
        {
            Console.WriteLine("Enter the side length of the square:");
            double side = Convert.ToDouble(Console.ReadLine());

            double area = side * side;

            Console.WriteLine("Area of the square is: " + area);
        }

        static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("Area of the rectangle is: " + area);
        }
    }
} 