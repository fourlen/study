using System;
using System.Collections.Generic;
using System.IO;


namespace shurup
{
    class program
    {
        static void Dot(int x, int y, Figure figure)
        {
            if (figure.Dot(x, y))
            {
                Console.WriteLine("Точка попадает в фигуру");
            } else
            {
                Console.WriteLine("Точка не попадает в фигуру");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите тип фигуры (круг(1) или квадрат(0)): ");
            int type = Convert.ToInt32(Console.ReadLine());
            Figure fig;
            if (type == 0)
            {
                Console.Write("Введите x координату левой верхней вершины: ");
                int vershx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y координату левой верхней вершины: ");
                int vershy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите сторону квадрата: ");
                int side = Convert.ToInt32(Console.ReadLine());
                Figure square = new Square(vershx, vershy, side);
                fig = square;
            }
            else
            {
                Console.Write("Введите x координату центра круга: ");
                int centerx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y координату центра круга: ");
                int centery = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите радиус круга: ");
                int radius = Convert.ToInt32(Console.ReadLine());
                Figure circle = new Circle(centerx, centery, radius);
                fig = circle;
            }
            Console.Write("Введите x координату точки: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввдите y координату точки: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Dot(x, y, fig);
        }
    }
}