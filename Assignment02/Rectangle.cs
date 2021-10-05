using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int rLength, rWidth, rHeight;

        //Default Constructor - Values set if no initial values provided by user.
        public Rectangle()
        {
            rLength = 1;
            rWidth = 1;
            rHeight = 1;
        }

        //Parameterized Constructor - Receives initial values from user.
        public Rectangle(int l, int w, int h)
        {
            this.rLength = l;
            this.rWidth = w;
            this.rHeight = h;

        }

        //Fetches the length of rectangle.
        public int GetLength()
        {
            return rLength;
        }

        //Sets the length of rectangle.
        public void SetLength(int length) 
        {
            rLength = length;
        }

        //Fetches the width of rectangle.
        public int GetWidth() 
        {
            return rWidth;        
        }

        //Sets the width of rectangle.
        public void SetWidth(int width) 
        {
            rWidth = width;
        }

        //Fetches the length of rectangle.
        public int GetHeight() 
        {
            return rHeight;
        }

        public void SetHeight(int height) 
        {
            rHeight = height;
        }

        public int GetVolume() 
        {
            return GetLength() * GetWidth() * GetHeight();
        }


    }
}
