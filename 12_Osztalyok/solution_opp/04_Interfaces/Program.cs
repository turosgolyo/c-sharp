Shape shape = new Square(10);

shape = new Rectangle(10, 20);
PrintShape(shape);

//nem jo mert nincs szerzodes
//IShape circle = new Circle(10);

void PrintShape(IShape shape)
{   
    if(shape is Square)
    {
        Console.WriteLine("Negyzet:");
        Console.WriteLine(shape);
    }
    else if(shape is Rectangle)
    {
        Console.WriteLine("Teglalap:");
        Console.WriteLine(shape);
    }

}