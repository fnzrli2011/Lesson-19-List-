using Lesson19;

class Program
{
    public static void Main(String[] args)
    {
        Book book = new Book("programming"){PageCount= 150 , AuthorName ="Farid Nazrali"};
        System.Console.WriteLine(book.Code);
        Book book2 = new Book("Linux Lesson for programmer"){PageCount=300,AuthorName="Nazrali Farid"};
        System.Console.WriteLine(book2.Code);
        Library library = new Library();
        library.AddBook(book);
        library.AddBook(book2);
        library.FindAllBooksbyNama("programming").ForEach
        (
            x=>
            {
                System.Console.WriteLine(x);
            }
        );
       System.Console.WriteLine(library.FindBookbyCode("LI2")); 
    }
}