using System;

namespace TilfeldigeFirkanter
{
    class VirtualScreen
    {
        public int width;
        public int height;
        public VirtualScreenCell[,] screen;

        public VirtualScreen(int rows, int columns)
        {
            width = rows;
            height = columns;
            screen = new VirtualScreenCell[width, height];
            for (int i=0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    screen[i, j] = new VirtualScreenCell();
                }
            }
        }

        public void AddBox( int top, int bottom, int left, int right)
        {
            screen[left, top].AddUpperLeftCorner();
            screen[right, top].AddUpperRightCorner();
            screen[left, bottom].AddLowerLeftCorner();
            screen[right, bottom].AddLowerRightCorner();
            for (int i = left+1; i<right; i++)
            {
                screen[i, top].AddHorizontal();
                screen[i, bottom].AddHorizontal();
            }
            for (int j = top + 1; j < bottom; j++)
            {
                screen[left, j].AddVertical();
                screen[right, j].AddVertical();
            }
        }

        public void AddRandomBox()
        {
            var rand = new Random();
            int left = rand.Next(width - 1);
            int right = rand.Next(left + 1, width);
            int top = rand.Next(height - 1);
            int bottom = rand.Next(top + 1, height);
            AddBox(top, bottom, left, right);
        }

        public void Show()
        {
            string image = "";
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    image += screen[i,j].GetCharacter();
                    if (i == width-1) image += "\n";
                }
            }
            Console.Clear();
            Console.WriteLine(image);
        }
    }
}
