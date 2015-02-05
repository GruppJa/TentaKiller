using System;
using System.Collections.Generic;
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
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public TentaKillerDBContext Data { get; set; }

        public MainWindow Window { get; set; }

        public void Main(object sender, StartupEventArgs e)
        {
            Data = new TentaKillerDBContext();
            // TODO Find and use that Load() method the documentation talks about...
            // Seems like using ToList(..) causes Navigate(..) to be called. (but why!?)
            // DbSet<Entity> https://msdn.microsoft.com/en-us/library/gg696460(v=vs.113).aspx
            // ObjectSet<Entity> https://msdn.microsoft.com/en-us/library/dn159797(v=vs.113).aspx
            // Data.Exams.Load();
            Data.Students.ToList<Student>();
            CollectionViewSource.GetDefaultView(Data.Students.Local).MoveCurrentTo(null);
            Data.Exams.ToList<Exam>();
            CollectionViewSource.GetDefaultView(Data.Exams.Local).MoveCurrentTo(null);
            
            Window = new MainWindow(this);
            Window.Show();
            Window.DataContext = Window;
        }
    }
}