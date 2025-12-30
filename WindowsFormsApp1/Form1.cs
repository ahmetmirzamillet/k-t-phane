using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kütüphane.Services;
using Kütüphane.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LinkedList<Book> books = new LinkedList<Book>();
        LinkedList<Student> students = new LinkedList<Student>();
        CustomStack<string> logs = new CustomStack<string>();

        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            books.Add(new Book("Sefiller", "Victor Hugo", "111", "Roman"));
            books.Add(new Book("1984", "George Orwell", "222", "Distopya"));
            books.Add(new Book("Suç ve Ceza", "Dostoyevski", "333", "Roman"));

            students.Add(new Student(1, "Ahmet"));
            students.Add(new Student(2, "Ayşe"));
            students.Add(new Student(3, "Mehmet"));

            RefreshLists();
        }

        private void RefreshLists()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
                lstBooks.Items.Add(book);

            lstStudents.Items.Clear();
            foreach (var student in students)
                lstStudents.Items.Add(student);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            books.Add(new Book(txtBookName.Text, "Yazar", "000", "Kategori"));
            logs.Push("Kitap eklendi");
            RefreshLists();
        }
    }
}
