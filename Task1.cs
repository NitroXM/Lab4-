using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Task1
    {
    public Task1(int x, string y)
    {
        this.x = x;
        this.y = y; 
    }
    public int x;
    public string y;
    public virtual void Method1(int x, string y)
    {
        Console.WriteLine($"{x}, {y}");
    }
    }

