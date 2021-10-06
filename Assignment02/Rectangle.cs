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
            if(rLength > 0)
            {
                return rLength;
            }
            else
            {
                return 0;
            }
            
        }

        //Sets the length of rectangle.
        public int SetLength(int length) 
        {
            if(length > 0)
            {
                return rLength=length;
            }
            else
            {
                return 0;
            }    

        }


        //Fetches the width of rectangle.
        public int GetWidth() 
        {
            if (rWidth > 0)
            {
                return rWidth;
            }
            else
            {
                return 0;
            }
                   
        }

        //Sets the width of rectangle.
        public int SetWidth(int width) 
        {
            
            if (width > 0)
            {
                return rWidth = width;
            }
            else
            {
                return 0;
            }
        }

        //Fetches the length of rectangle.
        public int GetHeight() 
        {
            if (rHeight > 0)
            {
                return rHeight;
            }
            else
            {
                return 0;
            }
        }

        public int SetHeight(int height) 
        {
            if (height > 0)
            {
                return rHeight = height;
            }
            else
            {
                return 0;
            }

            
        }

        public int GetVolume() 
        {
           
            return GetLength() * GetWidth() * GetHeight();
        }


    }
}
