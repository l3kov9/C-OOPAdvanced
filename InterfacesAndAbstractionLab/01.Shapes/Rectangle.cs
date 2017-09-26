using System;

namespace _01.Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int heigth;

        public Rectangle(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.heigth - 1; ++i)
                DrawLine(this.width, '*', ' ');
            DrawLine(this.width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }

    }
}
