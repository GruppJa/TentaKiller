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
    /// Interaction logic for ExamPage.xaml
    /// </summary>
    public partial class ExamPage : Page
    {
        protected MainWindow mainWindow;

        public ExamPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }

        public void RemoveExam(object sender, EventArgs ea)
        {
            mainWindow.app.Data.Exams.Local.Remove((Exam)DataContext);
            mainWindow.app.Data.SaveChanges();
            mainWindow.Navigate(mainWindow.ExamsPage);
        }
    }
}
