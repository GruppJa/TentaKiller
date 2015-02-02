using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TentaKiller.Models;

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
            // https://msdn.microsoft.com/en-us/library/dn159797(v=vs.113).aspx
            Data.Students.ToList<Student>();
            Data.Exams.ToList<Exam>();
            
            Window = new MainWindow(this);
            Window.Show();
            Window.DataContext = this;
        }
    }
}