using System;

class Program
{
    static void Main(string[] args)
    {
        //Square
        Square mySquare = new Square("pink", 35);

        //Rectangle
        Rectangle myRectangle = new Rectangle("blue", 10,30);

        //Circle
        Circle myCircle = new Circle("Green", 20);

        List<Shape> myShapes = new List<Shape>();

        myShapes.Add(mySquare);
        myShapes.Add(myRectangle);
        myShapes.Add(myCircle);

        myShapes.ForEach( shape => {
            Console.WriteLine($"My shape Color: {shape.GetColor()},  Area: {shape.GetArea().ToString()}");
        });

    }
}