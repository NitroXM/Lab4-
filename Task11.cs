using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Task11 : Task1 
    {
    public Task11(int x, string y) : base(x, y)
    {
    }
    public override void Method1(int x, string y)
    {
        base.Method1(x, y);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"int {x}");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"string {y}");
    }
    }

