using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson19
{
    public class Library
    {
        List<Book>books=new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public List<Book> FindAllBooksbyNama(string value)
        {
            List<Book>NameBooks=new List<Book>();
            books.ForEach
            (x=>
            {
                if(x.Name==value)
                {
                    NameBooks.Add(x);
                }
            }
            );
            return NameBooks;
        }
            public Book FindBookbyCode(string value)
        {
            Book b=null;
            books.ForEach
            (x=>
            {
                if(x.Code==value)
                {
                    b=x;
                }
            }
            );
            if(b==null)
            {
                throw new NullReferenceException("Bu koda sahi kitab tapilmadi!!!");
            }
            return b;
        }
        public List<Book> FindAllBooksByRange(int min , int max)
        {
            List<Book>RangeBooks=new List<Book>();
            books.ForEach(
                x=>
                {
                    if(x.PageCount>=min && x.PageCount<=max)
                    {
                        RangeBooks.Add(x);
                    }
                }
            );
            return RangeBooks;
        }
        public void RemoveBookByCode(string value)
        {
            books.ForEach(
                x=>
                {
                    if(x.Code==value)
                    {
                        books.Remove(x);
                    }
                }
            );
        }
    }
}