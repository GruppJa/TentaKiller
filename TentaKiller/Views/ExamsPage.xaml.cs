using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace TentaKiller
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ExamsPage : Page
    {
        protected MainWindow mainWindow;
        public ExamsPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }

        protected void SelectExam(object sender, SelectionChangedEventArgs ea)
        {
            if (ListView.SelectedItem == null)
                return;

            Console.WriteLine("\n ## herrow");
            Console.WriteLine("..sender :");
            Console.WriteLine(sender);
            Console.WriteLine("..arguments :");
            Console.WriteLine(ea);
            Console.WriteLine("..item :");
            Console.WriteLine(ListView.SelectedItem);
            Console.WriteLine("..items :");
            Console.WriteLine(ListView.SelectedItems);

            mainWindow.ExamPage.DataContext = ListView.SelectedItem;
            ListView.UnselectAll();
            mainWindow.Navigate(mainWindow.ExamPage);
        }
    }
}
