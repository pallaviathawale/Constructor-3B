using static ConstructorsDemo.InterfaceDemo;

namespace ConstructorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Constructor obj = new Constructor("pallavi", 25);
            //obj.Display();

            //Constructor obj1 = new Constructor();
            //obj1.Display();

            IDrawable drawable;
            drawable = new Addition();
            drawable.Operation();
            drawable = new Subtraction();
            drawable.Operation();
            drawable = new Multiplication();
            drawable.Operation();
        }
    }
}