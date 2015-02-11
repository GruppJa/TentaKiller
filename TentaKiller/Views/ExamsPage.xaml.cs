using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// Interaction logic for ExamsPage.xaml
    /// </summary>
    public partial class ExamsPage : Page
    {
        protected MainWindow mainWindow;

        public ExamsPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            listView.SelectionChanged += SelectionChanged;
            listView.IsSynchronizedWithCurrentItem = true;
            listView.ItemsSource = window.app.Data.Exams.Local;
        }

        void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listView.SelectedItem == null)
                return;

            mainWindow.ExamPage.Exam = (Exam)listView.SelectedItem;
            listView.UnselectAll();
            mainWindow.Navigate(mainWindow.ExamPage);
        }

        public void CreateExam(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            mainWindow.app.Data.Exams.Add(exam);
            mainWindow.app.Data.SaveChanges();
            mainWindow.ExamPage.Exam = exam;
            mainWindow.Navigate(mainWindow.ExamPage);
            mainWindow.AddFeedback("Exam created (" + exam.Id + ")");
        }
    }
}
