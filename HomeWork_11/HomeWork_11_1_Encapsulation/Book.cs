using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11_1_Encapsulation
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;

        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        public int Year
        {
            get { return year; }
            private set
            {
                if (value < 1800)
                {
                    Console.WriteLine("Wrong year");
                    year = 0;
                }
                else
                {
                    year = value;
                }
            }
        }
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            Year = year;
        }
    }
}
