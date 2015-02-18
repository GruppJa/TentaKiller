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
    public partial class TrialPage : Page
    {
        protected MainWindow mainWindow;

        protected TentaKiller.Models.Trial trial;
        public TentaKiller.Models.Trial Trial
        {
            get { return trial; }
            set
            {
                trial = value;
                DataContext = value;
                partList.ClearValue(ItemsControl.ItemsSourceProperty);
                partList.ItemsSource = value.Parts;
            }
        }

        public TrialPage(MainWindow window)
        {
            mainWindow = window;
            InitializeComponent();
        }

        private void Grade(object sender, RoutedEventArgs e)
        {
            // TODO Points stuff.. not really correct. part.Points should reflect Exam-Challange relation (non-existant property atm.)
            trial.Ended = DateTime.Now;
            trial.Points = 0;
            trial.MaxPoints = 0;
            IEnumerator<TrialPart> i = trial.Parts.GetEnumerator();
            while (i.MoveNext())
            {
                TrialPart part = i.Current;
                trial.MaxPoints += part.Points;
                if (part.Answer != null && part.Answer.Equals(part.Challange.Answer))
                {
                    trial.Points += part.Points;
                }
            }
            trial.Graded = true;

            mainWindow.app.Data.SaveChanges();

            mainWindow.Navigate(trial);
        }
    }
}
