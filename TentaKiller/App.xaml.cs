using System;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TentaKiller.Models;
using TentaKiller.Views;

namespace TentaKiller
{
    /// <summary>
    /// Main / entry point
    /// Application context
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Data
        public TentaKillerDBContext Data { get; set; }

        // GUI
        public MainWindow Window { get; set; }

        public void Main(object sender, StartupEventArgs e)
        {
            Data = new TentaKillerDBContext();
            
            Window = new MainWindow(this);
            Window.Show();
            Window.Navigate(Window.SplashPage);

            // Populate local data (and set default selections to none)
            // TODO Find and use that Load() method the documentation talks about...
            // DbSet<Entity> https://msdn.microsoft.com/en-us/library/gg696460(v=vs.113).aspx
            // ObjectSet<Entity> https://msdn.microsoft.com/en-us/library/dn159797(v=vs.113).aspx
            // Data.Exams.Load();
            Data.Students.ToList<Student>();
            CollectionViewSource.GetDefaultView(Data.Students.Local).MoveCurrentTo(null);
            Data.Exams.ToList<Exam>();
            CollectionViewSource.GetDefaultView(Data.Exams.Local).MoveCurrentTo(null);
            Data.Challanges.ToList<Challange>();
            CollectionViewSource.GetDefaultView(Data.Challanges.Local).MoveCurrentTo(null);
            Data.Lies.ToList<Lie>();
            CollectionViewSource.GetDefaultView(Data.Lies.Local).MoveCurrentTo(null);
            Data.Trials.ToList<Trial>();
            CollectionViewSource.GetDefaultView(Data.Trials.Local).MoveCurrentTo(null);
            Data.TrialParts.ToList<TrialPart>();
            CollectionViewSource.GetDefaultView(Data.TrialParts.Local).MoveCurrentTo(null);
        }
    }
}