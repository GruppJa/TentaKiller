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
    /// Interaction logic for StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        protected MainWindow mainWindow;

        protected Student student;
        public Student Student { 
            get { return student; } 
            set { 
                student = value; 
                DataContext = value;
                trialList.ItemsSource = student.Trials;
                trialList.SelectionChanged += trialList_SelectionChanged;
            }
        }

        void trialList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (trialList.SelectedItem == null) return;

            mainWindow.Navigate((Trial)trialList.SelectedItem);
        }

        public StudentPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }

        public void BecomeStudent(object sender, EventArgs ea)
        {
            mainWindow.LoggedInStudent = student;
        }

        public void RemoveStudent(object sender, EventArgs ea)
        {
            MessageBoxResult result = MessageBox.Show("Are you certain you'd like to remove this Student? (This is irreversable).", "Remove Student?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                // TODO remove related Challanges (unless that Challange is part of another Exam)
                mainWindow.app.Data.Students.Local.Remove(student);
                mainWindow.app.Data.SaveChanges();
                mainWindow.AddFeedback("Removed Student '" + student.Name + "' [" + student.Id + "]");
                mainWindow.Navigate(mainWindow.StudentsPage);
            }
        }
    }
}
