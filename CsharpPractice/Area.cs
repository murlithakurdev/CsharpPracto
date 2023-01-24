using CsharpPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class Area
    {
        public void Circle(int r) 
        {
            float pi = 3.14f;
            float area = pi * r * r;
            Console.WriteLine(area);
        }
        public void Circle(float r)
        {
            float p = 3.14f;
            float area = p * r * r;
            Console.WriteLine(area);
        }
        public void Circle()
        {
            int r = 6;
            float pi = 3.14f;
            float area = pi * r * r;
            Console.WriteLine(area);
        }

    }
    public class CircleArea : Area
    {
        public void Calculate(int r, float a)
        {
            Circle(r);
            Circle(a);
            Circle();
        }
    }

    public class RectengularArea : Area
    {
        public void Calculate(int r, float a)
        {
            Circle(r);
            Circle(a);
            Circle();
        }
    }
}
//https://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@github.com/murlithakurdev/CsharpPracto.git


