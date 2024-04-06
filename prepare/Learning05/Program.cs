using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square(4, "red");
        Rectangle rec = new Rectangle(3, 5, "blue");
        Circle cr = new Circle(10, "black");

        List <Shape> figures = new List<Shape>();

        figures.Add(sq);
        figures.Add(rec);
        figures.Add(cr);

        foreach(Shape sh in figures)
        {
            Console.WriteLine(sh.GetArea());
            Console.WriteLine(sh.GetColor());
        }
    }
}