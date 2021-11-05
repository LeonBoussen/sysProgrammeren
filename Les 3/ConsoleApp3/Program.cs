using System;

namespace ConsoleApp3
{
    class Program
    {
        private class titel
        {

        }

        private class Kamer
        {
            private titel[][] titel;

            public Kamer(int width, int height)
            {
                this.titel = new titel[height][];

                for (int i = 0; i < height; i++)
                {
                    this.titel[i] = new titel[width];

                    for (int j = 0; j < width; j++)
                    {
                        this.titel[i][j] = new titel();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Kamer kammer = new Kamer(69,420);
        }
    }
}
