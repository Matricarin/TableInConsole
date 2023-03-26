using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableInConsole
{
    public class Table
    {
        private int _size;
        private string _text;
        private char _border;
        
        public Table(int size, string text, char border)
        {
            _size = size;
            _text = text;
            _border = border;
        }

        public void PrintBorder()
        {
            for(int i = 0; i < 40; i++)
            {
                Console.Write(this._border);        
            }
            Console.WriteLine();
        }

        public void PrintEmptyLine()
        {
            Console.Write(this._border);
            for(int i = 0; i < 38; i++)
            {
                Console.Write(' ');        
            }
            Console.Write(this._border);
            Console.WriteLine();
        }

        public void PrintText()
        {
            string[] array = SplitLine(this._text);
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(this._border);
                Console.Write($"{array[i], -38}"); 
                Console.Write(this._border);
                Console.WriteLine();      
            }
        }

        public void PrintChess()
        {
            string[] array = SplitLine(this._text);
            for(int i = 0; i < array.Length + 2 * (_size - 1); i++)
            {
                Console.Write(this._border);
                for(int j = 0; j < 19; j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(' ');
                        Console.Write(this._border);
                    }
                    else
                    {
                        Console.Write(this._border);
                        Console.Write(' ');
                    }      
                }
                Console.Write(this._border);
                Console.WriteLine();      
            }
        }

        private string[] SplitLine(string text)
        {
            int length = CheckTextLength(text);
            string[] array = new string[length];
            if(length > 1)
            {
                for(int i = 0; i < length; i++)
                {
                    int end = text.Length - i * 38;
                    if(end < 38)
                    {
                        array[i] = text.Substring(i*38);
                    }
                    else
                    {
                        array[i] = text.Substring((i * 38), 38);
                    }
                }
                return array;
            }
            else
            {
                return new string[1]{text};
            }

        }

        private int CheckTextLength(string text)
        {
            if(text.Length >38)
            {
                double length = Convert.ToDouble(text.Length) / 38.0;
                return (int)Math.Ceiling(length);
            }
            else
            {
                return 1;
            }
        }

        public void PrintSquare()
        {
            int left = 0;
            int right = 37;
            for(int i = 0; i < 38; i++)
            {
                Console.Write(this._border);
                for(int j = 0; j < 38; j++)
                {
                    if(left == j || right == j)
                    {
                        Console.Write(this._border);                        
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                left++;
                right--;
                Console.Write(this._border);
                Console.WriteLine();
            }
        }
    }
}