using DemoLibrary;
using DemoLibrary.DigitalMovie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Demo
{
    public class Program
    {
        public static void Main()
        {
            IBorrowableDVD dvd = new DVD();
            dvd.Title = "Learning Design Patterns";
            dvd.Borrower = "Kostas";
            dvd.BorrowDate = DateTime.Now;
            dvd.CheckIn();

            IBorrowableBook book = new Book();
            book.Title = "Harry Potter";
            book.Borrower = "Kostas";
            book.BorrowDate= DateTime.Now;  
            book.CheckIn();

            IBorrowableDVD movie = new DigitalMovie();
            movie.Title = "James Bond part1";
            movie.Borrower = "Kostas";
            movie.BorrowDate = DateTime.Now;
            movie.CheckIn();

            IBorrowableAudioBook audioBook = new AudioBook();
            audioBook.Title = "Sleeping sounds 24/7";
            audioBook.Borrower = "Kostas";
            audioBook.BorrowDate = DateTime.Now;
            audioBook.CheckIn();

            ILibraryItem referenceBook = new ReferenceBook();
            referenceBook.Title = "SOLID Principles";
            referenceBook.LibraryId = "213";
            Console.WriteLine($"Reference Book created. Title: { referenceBook.Title}, Library Id: {referenceBook.LibraryId}");

            Console.ReadLine();
        }
    }
}
