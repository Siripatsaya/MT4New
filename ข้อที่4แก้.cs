using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, y1, x2, y2, x , y, dx, dy, step;
            x1 = float.Parse(Console.ReadLine());
            y1 = float.Parse(Console.ReadLine());
            x2 = float.Parse(Console.ReadLine());
            y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;         

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else 
            {
                step = Math.Abs(dy);
            }

            dx /= step;
            dy /= step;

            x = x1;
            y = y2;
            int i = 1;

            while(i <= step)
            {
                Console.WriteLine(x + "," + y);
                x += dx;
                y += dy;
                i++;
            }
            Console.ReadLine();
        }
    }
}
