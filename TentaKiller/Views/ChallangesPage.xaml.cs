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
    /// Interaction logic for ChallangesPage.xaml
    /// </summary>
    public partial class ChallangesPage : Page
    {
        protected MainWindow mainWindow;

        public ChallangesPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
            challangeList.SelectionChanged += SelectionChanged;
            challangeList.IsSynchronizedWithCurrentItem = true;
            challangeList.ItemsSource = window.app.Data.Challanges.Local;
        }

        void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (challangeList.SelectedItem == null)
                return;

            mainWindow.ChallangePage.Challange = (Challange)challangeList.SelectedItem;
            challangeList.UnselectAll();
            mainWindow.Navigate(mainWindow.ChallangePage);
        }

        public void CreateChallange(object sender, EventArgs e)
        {
            Challange challange = new Challange();
            mainWindow.app.Data.Challanges.Add(challange);
            mainWindow.app.Data.SaveChanges();
            mainWindow.ChallangePage.Challange = challange;
            mainWindow.Navigate(mainWindow.ChallangePage);
            mainWindow.AddFeedback("Challange created (" + challange.Id + ")");
        }
    }
}
