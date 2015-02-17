using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Speech.Synthesis;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public App app { get; set; }

        // rudimentary User/Session support
        public Student LoggedInStudent { get; set; }

        // Pages / Views
        public Page CurrentPage { get; set; }
        public ChallangePage ChallangePage { get; set; }
        public ChallangesPage ChallangesPage { get; set; }
        public ExamPage ExamPage { get; set; }
        public ExamsPage ExamsPage { get; set; }
        public StudentPage StudentPage { get; set; }
        public StudentsPage StudentsPage { get; set; }
        public TakeExamPage TakeExamPage { get; set; }

        // Speech / Voice
        protected SpeechSynthesizer speaker = new SpeechSynthesizer();
        public bool VoiceEnabled { get; set; }

        public MainWindow(App app)
        {
            VoiceEnabled = false;

            this.app = app;

            ChallangePage = new ChallangePage(this);
            ChallangesPage = new ChallangesPage(this);
            ExamsPage = new ExamsPage(this);
            ExamPage = new ExamPage(this);
            StudentPage = new StudentPage(this);
            StudentsPage = new StudentsPage(this);
            TakeExamPage = new TakeExamPage(this);

            InitializeComponent();

            AddFeedback("This is the a feedback list. Click on a message to remove it.");
            AddFeedback("Welcome to Tenta Killer! :)");
        }


        public void AddFeedback(string message) {
            // Add at the beginning so it displays first in when displaying.
            String date = DateTime.Now.ToString("H" + ":" + "mm");
            feedbackList.Items.Insert(0, date + " " + message);
        }

        public bool Confirm(string title, string question)
        {
            MessageBoxResult result = MessageBox.Show(question, title, MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            return result == MessageBoxResult.Yes;
        }

        public void Navigate(Page page)
        {
            if (VoiceEnabled) speaker.Speak("Navigating to " + page.Title);

            frame.NavigationService.Navigate(page);
        }

        public void Navigate(Challange challange)
        {
            ChallangePage.Challange = challange;
            Navigate(ChallangePage);
        }

        public void Navigate(Exam exam)
        {
            ExamPage.Exam = exam;
            Navigate(ExamPage);
        }

        public void Navigate(Student student)
        {
            StudentPage.Student = student;
            Navigate(StudentPage);
        }

        protected void RemoveFeedback(object sender, RoutedEventArgs ea)
        {
            feedbackList.Items.Remove(((TextBlock)sender).Text);
        }

        public void ToggleVoiceEnabled(object sender, EventArgs ea)
        {
            if (VoiceEnabled = !VoiceEnabled) speaker.Speak("Voice enabled");
        }

        public void ViewChallanges(object sender, EventArgs e)
        {
            Navigate(ChallangesPage);
        }

        public void ViewExams(object sender, EventArgs e)
        {
            Navigate(ExamsPage);
        }

        public void ViewStudents(object sender, EventArgs e)
        {
            Navigate(StudentsPage);
        }
    }
}