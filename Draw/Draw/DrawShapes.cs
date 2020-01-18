using System;

namespace Shapes
{
    public class ShapeDrawer
    {

        public static string DrawSquare(int height, int width)
        {
            string unable = "Cannot draw that shape.";
            string square = "";

            if (width < 1 || height < 1)
            {
                return unable;
            }
            else if (height == 1)
            {
                for (int i = 0; i < width; i++)
                {
                    square += "-";
                }
            }
            else if (width == 1)
            {
                for (int i = 0; i < height; i++)
                {
                    square += "-\n";
                }
            }
            else
            {
                for (int i = 0; i < width; i++)
                {
                    square += "-";
                }

                square += "\n";

                for (int i = 0; i < height - 2; i++)
                {
                    square += "-";
                    for (int k = 0; k < width - 2; k++)
                    {
                        square += " ";
                    }
                        square += "-\n";
                }

                for (int i = 0; i < width; i++)
                {
                    square += "-";
                }
            }
            return square;
        }

        public static string DrawIsoscelesTriangle(int size)
        {
            string unable = "Cannot draw that shape.";
            string triangle = "";

            if (size < 2)
            {
                return unable;
            }
            int i, j, k, l;
            l = size - 1;
            for (i = 0; i < size + 1; i++)
            {

                for (j = 0; j < i; j++)
                {
                    triangle += "*";
                }
                if (i != 0)
                {
                    triangle += "\n";
                }
            }
            for (i = 0; i < size - 1; i++)
            {
                l--;

                for (k = l; k >= 0; k--)
                {
                    triangle += "*";
                }
                if (l != 0)
                {
                    triangle += "\n";
                }
            }
            return triangle;
        }

    }
}