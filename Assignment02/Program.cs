using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }

        public int askLength()
        {
            //Input length of rectangle.
            string rectLength = string.Empty;
            int length;
            do
            {
                Console.Write("Please enter the length of rectangle. ");
                rectLength = Console.ReadLine();
            } while (!int.TryParse(rectLength, out length) || (length < 0));

            return length;
        }

        public int askWidth()
        {
            //Input width of rectangle.
            string rectWidth = string.Empty;
            int width;
            do
            {
                Console.Write("Please enter the width of rectangle. ");
                rectWidth = Console.ReadLine();
            } while (!int.TryParse(rectWidth, out width) || (width < 0));

            return width;
        }

        public int askHeight()
        {
            //Input height of rectangle.
            string rectHeight = string.Empty;
            int height;
            do
            {
                Console.Write("Please enter the height of rectangle. ");
                rectHeight = Console.ReadLine();
            } while (!int.TryParse(rectHeight, out height) || (height < 0));

            return height;
        }

        public void Go()
        {
            int l = askLength();
            int w = askWidth();
            int h = askHeight();

            //Instantiate rectangle object with the values of lenght, width and height provided by the user.
            Rectangle rectObj = new Rectangle(l, w, h);

            bool flag = true;

            do
            {
                string selection = string.Empty;
                int selectedOption;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a value between 1-8 ");
                    Console.WriteLine();
                    Console.WriteLine("Please choose an option [1-8] \n1.Get Rectangle Length\n2.Change Rectangle Length\n3.Get Rectangle Width\n4.Change Rectangle Width\n5.Get Rectangle Height\n6.Change Rectangle Height\n7.Get Rectangle Volume\n8.Exit\n");
                    Console.Write("Enter a value: ");
                    selection = Console.ReadLine();
                } while (!int.TryParse(selection, out selectedOption));


                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Length of rectangle: {0}\n",rectObj.GetLength());
                        break;

                    case 2:
                        l = askLength();
                        rectObj.SetLength(l);
                        break;

                    case 3:
                        Console.WriteLine("Width of rectangle: {0}\n", rectObj.GetWidth());
                        break;

                    case 4:
                        w = askWidth();
                        rectObj.SetWidth(w);
                        break;

                    case 5:
                        Console.WriteLine("Height of rectangle: {0}\n", rectObj.GetHeight());
                        break;

                    case 6:
                        h = askHeight();
                        rectObj.SetHeight(h);
                        break;

                    case 7:
                        Console.WriteLine("Volume of rectangle: {0}\n", rectObj.GetVolume());
                        break;

                    case 8:
                        flag = false;
                        return;
                        
                    default:
                        Console.Write("Invalid selection made. Please make a selection between 1-8 \n");
                        break;

                }


            } while (flag != false);
            
        }
    }
}
