using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    //internal Access Specifier
    internal class InternalModifiers
    {
        int Num1;
        int Num2;

        public void SetData(int a, int b)
        {
            Num1 = a;
            Num2 = b;
        }

        public void DisplayData()
        {
            Console.WriteLine("Number 1 is: " +Num1);
            Console.WriteLine("Number 2 is: " + Num2);
        }
    }
     //Private Acees Specifier
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds..");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
    //Protected Access Specifier
    public class Base
    {
        protected int num1;
    }

    public class Derived : Base
    {
        public int num2;

        public int Add()
        {
            num1 = num2;

            return num1 + num2;

        }
    }
    //Public Aceess Specifier
    public class Student
    {
        public string name = "Rahul";

        public void print()
        {
            Console.WriteLine("Hello there");
        }
    }
}
