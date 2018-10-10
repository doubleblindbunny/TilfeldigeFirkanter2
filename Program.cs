
using System;

namespace TilfeldigeFirkanter2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var box1 = new Box(random, 40, 18);
            var box2 = new Box(random, 40, 18);
            var box3 = new Box(random, 40, 18);
            var box4 = new Box(random, 40, 18);
            var screen = new VirtualScreen(50, 20);
            screen.Add(box1);
            screen.Add(box2);
            screen.Add(box3);
            screen.Add(box4);
            screen.Show();
        }
    }
}
