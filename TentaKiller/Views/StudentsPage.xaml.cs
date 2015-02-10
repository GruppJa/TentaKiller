using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TentaKiller.Models;

namespace TentaKiller.Views
{
    /// <summary>
    /// Interaction logic for StudentsPage.xaml
    /// </summary>
    public partial class StudentsPage : Page
    {
        protected MainWindow mainWindow;

        public StudentsPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            // TODO listView.SelectionChanged += SelectionChanged;
            listView.IsSynchronizedWithCurrentItem = true;
            listView.ItemsSource = window.app.Data.Students.Local;
        }

        public void CreateStudent(object sender, EventArgs e)
        {
            Student student = new Student();
            mainWindow.app.Data.Students.Add(student);
            mainWindow.app.Data.SaveChanges();
            mainWindow.StudentPage.Student = student;
            mainWindow.Navigate(mainWindow.StudentPage);
            mainWindow.AddFeedback("Student created (" + student.Id + ")");
        }
    }
}
