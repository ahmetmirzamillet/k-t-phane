using UniversityLibrarySystem.DataStructures;

namespace UniversityLibrarySystem.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }

        public bool IsAvailable { get; set; }
        public int BorrowCount { get; set; }

        public CustomQueue<Student> ReservationQueue { get; set; }

        public Book(string title, string author, string isbn, string category)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Category = category;

            IsAvailable = true;
            BorrowCount = 0;
            ReservationQueue = new CustomQueue<Student>();
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({Category})";
        }
    }
}
