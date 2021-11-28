using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title("Život Pepika");
            LOTR.Pages(20);
            LOTR.Category("sci-fi");
            LOTR.Author("Štefan");
            LOTR.ReleaseDate(2022);
            LOTR.vypisovač();
                
            
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        public void Title(string gettitle)
        {
            title = gettitle;
        }
        public void Pages(int getpages)
        {
            pages = getpages;

        }
        public void Category(string getcategory)
        {
            category = getcategory;
        }
        public void Author(string getauthor)
        {
            author = getauthor;
        }
        public void ReleaseDate(int getreleaseDate)
        {
            releaseDate = getreleaseDate;
        }

        public void vypisovač()
        {
            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }

            
    }
}
