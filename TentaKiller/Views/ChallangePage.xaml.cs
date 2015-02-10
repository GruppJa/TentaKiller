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
    /// Interaction logic for ChallangePage.xaml
    /// </summary>
    public partial class ChallangePage : Page
    {
        protected MainWindow mainWindow;

        protected Challange challange;
        public Challange Challange { get { return challange; } set { challange = value; DataContext = value; } }

        public ChallangePage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }
    }
}
