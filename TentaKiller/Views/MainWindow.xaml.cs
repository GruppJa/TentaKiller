using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
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

namespace TentaKiller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected App app;

        // Pages / Views
        public Page CurrentPage { get; set; }
        public ExamPage ExamPage { get; set; }
        public ExamsPage ExamsPage { get; set; }
        public StudentPage StudentPage { get; set; }
        public StudentsPage StudentsPage { get; set; }

        // Speech / Voice
        protected SpeechSynthesizer speaker = new SpeechSynthesizer();
        protected bool VoiceEnabled { get; set; }

        public MainWindow(App app)
        {
            this.app = app;

            ExamPage = new ExamPage();
            ExamsPage = new ExamsPage();
            ExamsPage.DataContext = app.Data.Exams.Local;
            StudentPage = new StudentPage();
            StudentsPage = new StudentsPage();
            StudentsPage.DataContext = app.Data.Students.Local;

            InitializeComponent();
        }

        protected void CreateExam(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            app.Data.Exams.Add(exam);
            Save();
            ExamPage.DataContext = exam;
            Navigate(ExamPage);
        }

        protected void CreateStudent(object sender, EventArgs e)
        {
            Student student = new Student();
            app.Data.Students.Add(student);
            Save();
            StudentPage.DataContext = student;
            Navigate(StudentPage);
        }

        protected void Navigate(Page page)
        {
            if (VoiceEnabled) speaker.Speak("Navigating to " + page.Title);

            frame.NavigationService.Navigate(page);
        }

        protected void Save()
        {
            Console.WriteLine("Saving..!");
            try
            {
                app.Data.SaveChanges();
                Console.WriteLine("Saved!");
            }
            catch (DbUpdateException err)
            {
                Console.WriteLine("Save ERROR : ", err.Message);
                Console.WriteLine(".. : ", err.StackTrace);
            }
        }

        protected void ToggleVoiceEnabled(object sender, EventArgs ea)
        {
            if (VoiceEnabled = !VoiceEnabled) speaker.Speak("Voice enabled");
        }

        protected void ViewExams(object sender, EventArgs e)
        {
            Navigate(ExamsPage);
        }

        protected void ViewStudents(object sender, EventArgs e)
        {
            Navigate(StudentsPage);
        }
    }
}