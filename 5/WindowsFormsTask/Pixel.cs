using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsTask
{
    class Pixel
    {
        private int x;
        private int y;
        private int color_r;
        private int color_g;
        private int color_b;
        public Pixel()
        {
            x = 0;
            y = 0;
            color_b = 0;
            color_g = 0;
            color_r = 0;
        }

        public Pixel(int x, int y, System.Drawing.Color c)
        {
            if(x<0 || y<0)
                throw new ArgumentException("Заданы отрицательные координаты");
            this.x = x;
            this.y = y;
            color_b = c.B;
            color_g = c.G;
            color_r = c.R;
        }

        public Pixel(int x, int y, int r, int g, int b)
        {
            if (x < 0 || y < 0)
                throw new ArgumentException("Заданы отрицательные координаты");
            this.x = x;
            this.y = y;
            if(r<0 || r>255|| g < 0 || g > 255|| b < 0 || b > 255)
                throw new ArgumentException("Не корректно задан цвет");
            color_b = b;
            color_g = g;
            color_r = r;
        }

        public System.Drawing.Color GetColor()
        {
            return  System.Drawing.Color.FromArgb(color_r, color_g, color_b);
        }
        public int X
        {
            get { return x; }
            set
            {
                if(value<0)
                    throw new ArgumentException("Задана отрицательная координата X");
                x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Задана отрицательная координата Y");
                y = value;
            }
        }

        public int R
        {
            get { return color_r; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Не корректно задан оттенок красного");
                color_r = value;
            }
        }

        public int G
        {
            get { return color_g; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Не корректно задан оттенок зеленого");
                color_g = value;
            }
        }

        public int B
        {
            get { return color_b; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Не корректно задан оттенок синего");
                color_b = value;
            }
        }

        public override string ToString()
        {
            return "Координаты: ("+x+", "+y+"), цвет: ("+R+", "+G+", "+B+ ")";
        }

    }
}
