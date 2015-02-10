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
        protected TentaKiller.Models.Exam exam;
        public TentaKiller.Models.Exam Exam {
            get { return exam; }
            set {
                exam = value;
                DataContext = value;
                //  ItemsSource="{Binding Challanges, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" IsSynchronizedWithCurrentItem="True"
                challangeList.IsSynchronizedWithCurrentItem = false;
                challangeList.ItemsSource = value.Challanges;
            } }

        public ExamPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }

        public void AddNewChallange(object sender, EventArgs ea)
        {
            Challange challange = new Challange();
            exam.Challanges.Add(challange);
            challange.Exams.Add(exam);
            mainWindow.app.Data.Challanges.Add(challange);
            mainWindow.app.Data.SaveChanges();
            mainWindow.ChallangePage.Challange = challange;
            mainWindow.Navigate(mainWindow.ChallangePage);
        }

        public void RemoveExam(object sender, EventArgs ea)
        {
            mainWindow.app.Data.Exams.Local.Remove(exam);
            mainWindow.app.Data.SaveChanges();
            mainWindow.AddFeedback("Removed exam '" + exam.Name + "' [" + exam.Id + "]");
            mainWindow.Navigate(mainWindow.ExamsPage);
        }
    }
}
