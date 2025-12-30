using UniversityLibrarySystem.DataStructures;
using UniversityLibrarySystem.Models;

namespace UniversityLibrarySystem.Services
{
    public class LibraryService
    {
        public CustomLinkedList<Book> Books { get; private set; }
        public CustomLinkedList<Student> Students { get; private set; }
        public CustomStack<Log> Logs { get; private set; }

        public LibraryService()
        {
            Books = new CustomLinkedList<Book>();
            Students = new CustomLinkedList<Student>();
            Logs = new CustomStack<Log>();
        }

        // 📘 Kitap ekleme
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // 👤 Öğrenci ekleme
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        // 📗 Kitap ödünç verme
        public string BorrowBook(Book book, Student student)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                book.BorrowCount++;

                Logs.Push(new Log("Kitap ödünç alındı."));
                return "Kitap başarıyla ödünç verildi.";
            }
            else
            {
                book.ReservationQueue.Enqueue(student);
                int sıra = book.ReservationQueue.Count();

                Logs.Push(new Log("Kitap meşgul olduğu için öğrenci rezervasyon kuyruğuna eklendi."));
                return $"Kitap dolu. Rezervasyon alındı. Sıra numaranız: {sıra}";
            }
        }

        // 📕 Kitap iade
        public string ReturnBook(Book book)
        {
            book.IsAvailable = true;
            Logs.Push(new Log("Kitap iade edildi."));

            // Kuyrukta öğrenci varsa otomatik ata
            if (!book.ReservationQueue.IsEmpty())
            {
                Student nextStudent = book.ReservationQueue.Dequeue();
                book.IsAvailable = false;
                book.BorrowCount++;

                Logs.Push(new Log("Kitap kuyruktaki öğrenciye otomatik olarak atandı."));
                return $"Kitap {nextStudent.Name} adlı öğrenciye otomatik atandı.";
            }

            return "Kitap iade edildi ve şu an müsait.";
        }
    }
}
