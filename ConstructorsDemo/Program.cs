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

            //IDrawable drawable;
            //drawable = new Addition();
            //drawable.Operation();
            //drawable = new Subtraction();
            //drawable.Operation();
            //drawable = new Multiplication();
            //drawable.Operation();

            //AccessSpecifiers accessSpecifiers = new AccessSpecifiers();
            //Console.WriteLine(accessSpecifiers.PublicField);
            // Console.WriteLine(accessSpecifiers.PrivateField); // Error: PrivateField is inaccessible
            // Console.WriteLine(accessSpecifiers.ProtectedField); // Error: ProtectedField is inaccessible
           
            Console.WriteLine(".....Access Modifiers....\n");

            //private Access modifier

            BankAccount obj = new BankAccount(1000);

            obj.Deposit(500);
            decimal balance1 = obj.GetBalance();
            Console.WriteLine("\nAfter deposit balance is: " + balance1);
            obj.Withdraw(100);
            decimal balance2 = obj.GetBalance();
            Console.WriteLine("After withdraw balance is: " + balance2);
            //Public Access modifier
            Student student = new Student();

            Console.WriteLine("Name: " + student.name);

            student.print();

            //Protected Acess modifier

            Derived derived = new Derived();

            derived.num2 = 100;
            int result = derived.Add();
            Console.WriteLine("\nSum of two nums is :" + result + "\n");

            //internal Access modifier

            InternalModifiers modifiers = new InternalModifiers();

            modifiers.SetData(22, 32);
            modifiers.DisplayData();

        }
    }
}