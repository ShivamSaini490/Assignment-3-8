using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MyClass
{
    private void PrivateMethod()
    {
        Console.WriteLine("This is a private method.");
    }

    public void CallPrivateMethod()
    {
        Console.WriteLine("Calling the private method...");
        PrivateMethod(); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        myObject.CallPrivateMethod();
    }
}
