using UniversityLibrarySystem.Models;

namespace UniversityLibrarySystem.Services
{
    public static class DataSeeder
    {
        public static void Seed(LibraryService libraryService)
        {
            // 👤 Öğrenciler
            libraryService.AddStudent(new Student(1, "Ali Yılmaz"));
            libraryService.AddStudent(new Student(2, "Ayşe Demir"));
            libraryService.AddStudent(new Student(3, "Mehmet Kaya"));
            libraryService.AddStudent(new Student(4, "Zeynep Çelik"));
            libraryService.AddStudent(new Student(5, "Can Aydın"));

            // 📚 Kitaplar
            libraryService.AddBook(new Book("Suç ve Ceza", "Dostoyevski", "ISBN001", "Roman"));
            libraryService.AddBook(new Book("Sefiller", "Victor Hugo", "ISBN002", "Roman"));
            libraryService.AddBook(new Book("1984", "George Orwell", "ISBN003", "Distopya"));
            libraryService.AddBook(new Book("Hayvan Çiftliği", "George Orwell", "ISBN004", "Politik"));
            libraryService.AddBook(new Book("Simyacı", "Paulo Coelho", "ISBN005", "Felsefe"));
            libraryService.AddBook(new Book("Kürk Mantolu Madonna", "Sabahattin Ali", "ISBN006", "Roman"));
            libraryService.AddBook(new Book("Beyaz Zambaklar Ülkesinde", "Grigory Petrov", "ISBN007", "Kişisel Gelişim"));
            libraryService.AddBook(new Book("Nutuk", "Mustafa Kemal Atatürk", "ISBN008", "Tarih"));
            libraryService.AddBook(new Book("İnce Memed", "Yaşar Kemal", "ISBN009", "Roman"));
            libraryService.AddBook(new Book("Fahrenheit 451", "Ray Bradbury", "ISBN010", "Distopya"));
        }
    }
}
