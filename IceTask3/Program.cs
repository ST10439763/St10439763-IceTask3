namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle("Rectangle", 10, 10);
            Circle circ = new Circle("Circle", 3);
            rect.Display();
            rect.calculateArea();

            Console.WriteLine();
            circ.Display();
            circ.calculateArea();
        }
    }
}
