using System;
using System.Collections.Generic;
using System.Text;

namespace QL_KTX.Presentation
{
    class GD
    {
        public GD(int a, int b)
        {
            Console.SetWindowSize(a, b);
        }
      
        public void pain(string a, int x, int y)
        {
            Console.SetWindowSize(100, 55);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(a);
        }
        public void pain2(string a, int x, int y)
        {
            Console.SetWindowSize(100, 55);
            Console.SetCursorPosition(x, y);
            Console.WriteLine(a);
        }
        public void ve(int x,int y)
        {
            Console.SetWindowSize(100, 55);
            Console.SetCursorPosition(x, y);
        }
    }
}
