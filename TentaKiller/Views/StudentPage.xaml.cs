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

namespace TentaKiller.Views
{
    /// <summary>
    /// Interaction logic for StudentPage.xaml
    /// </summary>
    public partial class StudentPage : Page
    {
        protected MainWindow mainWindow;

        protected TentaKiller.Models.Student student;
        public TentaKiller.Models.Student Student { get { return student; } set { student = value; DataContext = value; } }

        public StudentPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }
    }
}
