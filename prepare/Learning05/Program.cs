using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creamos la lista de formas
        List<Shape> shapes = new List<Shape>();

        // Instanciamos y agregamos las figuras
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iteramos por la lista (Polimorfismo en acción)
        foreach (Shape shape in shapes)
        {
            // El programa sabe qué GetArea() llamar según el tipo de objeto
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}