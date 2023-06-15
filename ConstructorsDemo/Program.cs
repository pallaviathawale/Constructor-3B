namespace ConstructorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Constructor obj = new Constructor("pallavi", 25);
            obj.Display();

            Constructor obj1 = new Constructor();
            obj1.Display();
        }
    }
}