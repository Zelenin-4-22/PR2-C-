using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal class Labotary2
{
    double one;
    double two;

    public void plus(double one, double two)
    {
        Console.WriteLine(one + two);
    }
    public void minus(double one, double two)
    {
        Console.WriteLine(one - two);
    }
    public void umnoshenie(double one, double two)
    {
        Console.WriteLine(one * two);
    }
    public void delenie(double one, double two)
    {
        if (two == 0)
        {
            Console.WriteLine("Некорректно");
        }
        else
        {
            Console.WriteLine(one / two);
        }

    }
    public void sqrt(double one, double two)
    {
        Console.WriteLine(Math.Sqrt(one));
        Console.WriteLine(Math.Sqrt(two));
    }
    public void stepen(double one, double two)
    {
        Console.WriteLine(Math.Pow(one, two));
    }
    public void okryglenie(double one, double two)
    {
        Console.WriteLine(Math.Round(one));
    }

    public void arksin(double one, double two)
    {
        Console.WriteLine(Math.Atan(one));
    }
    public void tan(double one, double two)
    {
        Console.WriteLine((double)Math.Tan(one));
    }
    public void tanh(double one, double two)
    {
        Console.WriteLine(Math.Tanh(one));
    }
    public void perimetr(double one, double two)
    {
        Console.WriteLine((one + two));
    }
    public void ploshadpr(double one, double two)
    {
        Console.WriteLine(one * two);
    }
    public void g(double one, double two)
    {
        Console.WriteLine(one * two);
    }
    public void plcube(double one)
    {
        Console.WriteLine(Math.Pow(one, 6));
    }
}

    
